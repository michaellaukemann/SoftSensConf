using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace SoftSensConf
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Globale variabler
        string defaultConfig = "C385IT001;0.0;500.0;40;440";
        string[] instrumentConfigs;
        List<MeasurementPoint> allMeasurementPoints = new List<MeasurementPoint>();

        
        private void comboBoxPorts_Enter(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBoxPorts.Items.Add(ports);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            SerialPort.Close();

            if (comboBoxPorts.SelectedIndex > -1)
            {
                SerialPort.PortName = comboBoxPorts.Items[comboBoxPorts.SelectedIndex].ToString();
                if (comboBoxBaud.SelectedIndex > -1)
                {
                    SerialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Items[comboBoxBaud.SelectedIndex]);
                 
                    try
                    {
                        SerialPort.Open();
                        timerConnection.Enabled = true;
                        textBoxConnectStatus.Text = "Connected";
                        textBoxConnectStatus.BackColor = System.Drawing.Color.Green;
                        textBoxConnectStatus2.Text = "Connected";
                        textBoxConnectStatus2.BackColor = System.Drawing.Color.Green;
                        textBoxConnectStatus3.Text = "Connected";
                        textBoxConnectStatus3.BackColor = System.Drawing.Color.Green;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Choose a baud rate to connect", "Baud rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxBaud.Focus();
                }
            }
            else
            {
                MessageBox.Show("Choose a com port to connect", "Com port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxPorts.Focus();
            }
        }


        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            timerConnection.Enabled = false;
            SerialPort.Close();
            

            if (!SerialPort.IsOpen)
            {
                
                textBoxConnectStatus.Text = "Not connected";
                textBoxConnectStatus.BackColor = System.Drawing.Color.Red;
                textBoxConnectStatus2.Text = "Not connected";
                textBoxConnectStatus2.BackColor = System.Drawing.Color.Red;
                textBoxConnectStatus3.Text = "Not connected";
                textBoxConnectStatus3.BackColor = System.Drawing.Color.Red;

            }
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.WriteLine("readconf");

                textBoxTagname.Clear();
                textBoxTagname.AppendText("Waiting for data");
                textBoxLRV.Clear();
                textBoxLRV.AppendText("Waiting for data");
                textBoxURV.Clear();
                textBoxURV.AppendText("Waiting for data");
                textBoxAL.Clear();
                textBoxAL.AppendText("Waiting for data");
                textBoxAH.Clear();
                textBoxAH.AppendText("Waiting for data");


                Thread.Sleep(1200);                       // Venter på svar fra arduino
                string availabledata = "";
                availabledata = SerialPort.ReadExisting().ToString();
                string[] analogReadings = availabledata.Split(';');


                if (analogReadings.Length == 5)
                {
                    textBoxTagname.Text = analogReadings[0];
                    textBoxLRV.Text = analogReadings[1];
                    textBoxURV.Text = analogReadings[2];
                    textBoxAL.Text = analogReadings[3];
                    textBoxAH.Text = analogReadings[4];
                }
                else
                {
                    MessageBox.Show("Failed to load configuration from instrument. Setting to default values.", "Read", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    instrumentConfigs = defaultConfig.Split(';');
                    textBoxTagname.Text = instrumentConfigs[0];
                    textBoxLRV.Text = instrumentConfigs[1];
                    textBoxURV.Text = instrumentConfigs[2];
                    textBoxAL.Text = instrumentConfigs[3];
                    textBoxAH.Text = instrumentConfigs[4];

                }
            }
            else
            {
                MessageBox.Show("Please connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxTagname.Text == "" || textBoxLRV.Text == "" || textBoxURV.Text == "" || textBoxAL.Text == "" || textBoxAH.Text == "")
            {
                MessageBox.Show("Enter all configurations", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string filename;
                string[] textfilecontent = { textBoxTagname.Text + ";" + textBoxLRV.Text + ";" + textBoxURV.Text + ";" + textBoxAL.Text + ";" + textBoxAH.Text };
                if (saveFileDialogConfig.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialogConfig.FileName;
                    File.WriteAllLines(filename, textfilecontent);
                    filename = "";
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string filename;
            string filecontent;
            string[] config;
            if (openFileDialogConfig.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialogConfig.FileName;
                filecontent = File.ReadAllText(filename);
                config = filecontent.Split(';');

                if (config.Length == 5)
                {
                    textBoxTagname.Text = config[0];
                    textBoxLRV.Text = config[1];
                    textBoxURV.Text = config[2];
                    textBoxAL.Text = config[3];
                    textBoxAH.Text = config[4];
                }
                else
                {
                    MessageBox.Show("Not able to load data from file", "Load from file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutWindow = new AboutBox1();
            aboutWindow.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                if (textBoxTagname.Text == "" || textBoxLRV.Text == "" || textBoxURV.Text == "" || textBoxAL.Text == "" || textBoxAH.Text == "")
                {
                    MessageBox.Show("Enter all configurations", "Configurations", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FormLogin login = new FormLogin();

                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        string writeString;

                        string passwordstring = FormLogin.passwordstring;
                        string[] config = { textBoxTagname.Text + ";" + textBoxLRV.Text + ";" + textBoxURV.Text + ";" + textBoxAL.Text + ";" + textBoxAH.Text };

                        writeString = "writeconf>" + passwordstring + ">" + string.Join(",", config);

                        //textBoxTagname.Text = writeString;      // Test

                        SerialPort.WriteLine(writeString);

                        Thread.Sleep(1500);                       // Venter på svar fra arduino
                        string confirmation;
                        confirmation = SerialPort.ReadExisting();

                        if (confirmation == "1")
                        {
                            MessageBox.Show("Config values successfully dowloaded to instrument", "Downloaded" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Wrong password", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxURV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxAH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timerChartAdd_Tick(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                if (comboBoxSignal.Text == "Raw")
                {
                    SerialPort.WriteLine("readraw");
                }
                else if (comboBoxSignal.Text == "Scaled")
                {
                    SerialPort.WriteLine("readscaled");
                }

                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
                
            }
        }

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {

            try
            {
                if (SerialPort.BytesToRead > 0)
                {
                    MeasurementPoint measuredPoint;
                    string availableData = "";
                    availableData = SerialPort.ReadExisting().ToString();

                    listBoxValues.Items.Add(availableData);

                    if (comboBoxSignal.Text == "Raw")
                    {
                        measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), (availableData));
                        chartValues.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                        allMeasurementPoints.Add(measuredPoint);
                    }
                    else if (comboBoxSignal.Text == "Scaled")
                    {

                        measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), (availableData));
                        chartValues.Series[1].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                        allMeasurementPoints.Add(measuredPoint);

                    }

                    timerStatus.Enabled = true;
                    timerSerialReceive.Enabled = false;
                }
            }
            catch (Exception)
            {
                
                //MessageBox.Show("Connection lost. Please check your connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (SerialPort.IsOpen)
            {
                SerialPort.DiscardInBuffer();                       // Fjerner gammel data fra serieporten
                SerialPort.DiscardOutBuffer();

                if (comboBoxSignal.SelectedIndex == -1)
                {
                    MessageBox.Show("Choose signal type", "Signal", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                }
                else
                {
                    
                    timerChartAdd.Enabled = true;
                    comboBoxSignal.Enabled = false;
                }
            }
            else
            {
                timerSerialReceive.Enabled = false;
                timerChartAdd.Enabled = false;
                timerStatus.Enabled = false;
                timerStatusReceive.Enabled = false;
                MessageBox.Show("Please connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            timerSerialReceive.Enabled = false;
            timerChartAdd.Enabled = false;
            timerStatus.Enabled = false;
            timerStatusReceive.Enabled = false;

            if (SerialPort.IsOpen)
            {
                if (MessageBox.Show("Do you want to save the data?", "Data", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (saveFileDialogData.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter streamWritePoints = new StreamWriter(saveFileDialogData.FileName))

                            foreach (MeasurementPoint point in allMeasurementPoints)
                            {
                                streamWritePoints.WriteLine(point.ToString());
                            }
                    }
                }
            }
            

            comboBoxSignal.Enabled = true;

        }

        public class MeasurementPoint
        {
            
            public String time { get; set; }
            
            public string vab { get; set; }
            
            public MeasurementPoint(String time, string vab)
            { 
                this.time = time;
                this.vab = vab;
            }
            
            public override string ToString()
            {
                return time + ";" + vab;
            }
        }
        
        
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.WriteLine("readstatus");
            }

            timerStatusReceive.Enabled = true;
            timerStatus.Enabled = false;
 
        }

        private void timerStatusReceive_Tick(object sender, EventArgs e)
        {

            try
            {
                if (SerialPort.BytesToRead > 0)
                {
                    int status;
                    status = Convert.ToInt32(SerialPort.ReadExisting());

                    if (status == 0)
                    {
                        textBoxStatus.Text = "Ok";
                        textBoxStatus.BackColor = System.Drawing.Color.White;
                    }
                    else if (status == 1)
                    {
                        textBoxStatus.Text = "Fail";
                        textBoxStatus.BackColor = System.Drawing.Color.Yellow;
                    }
                    else if (status == 2)
                    {
                        textBoxStatus.Text = "Alarm low";
                        textBoxStatus.BackColor = System.Drawing.Color.Orange;
                    }
                    else if (status == 3)
                    {
                        textBoxStatus.Text = "Alarm high";
                        textBoxStatus.BackColor = System.Drawing.Color.Red;
                    }



                    timerChartAdd.Enabled = true;
                    timerStatusReceive.Enabled = false;
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();
            chartValues.Series[0].Points.Clear();
            chartValues.Series[1].Points.Clear();
            textBoxStatus.Text = "";
        }

        private void chartValues_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSignal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timerConnection_Tick(object sender, EventArgs e)
        {
            if (!SerialPort.IsOpen)
            {
                timerConnection.Enabled = false;
                textBoxConnectStatus.Text = "Not connected";
                textBoxConnectStatus.BackColor = System.Drawing.Color.Red;
                textBoxConnectStatus2.Text = "Not connected";
                textBoxConnectStatus2.BackColor = System.Drawing.Color.Red;
                textBoxConnectStatus3.Text = "Not connected";
                textBoxConnectStatus3.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Connection lost. Please check your connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
