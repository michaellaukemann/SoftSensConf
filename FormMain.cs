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

        //Globale variabler fra arbeidskrav 1
        //string defaultConfig = "C385IT001;0.0;500.0;40;440";
        //string[] instrumentConfigs;
        //List<MeasurementPoint> allMeasurementPoints = new List<MeasurementPoint>();

        
        private void comboBoxPorts_Enter(object sender, EventArgs e)
        {
            // Kode fra arbeidskrav 1
            /*
            comboBoxPorts.Items.Clear();
            string[] comPorts = SerialPort.GetPortNames();
            foreach (string ports in comPorts)
            {
                comboBoxPorts.Items.Add(ports);
            }*/
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.Text !="" && comboBoxBaud.Text != "" && textBox_DAUConnect.Text == comboBoxDAUfind.Text)
            {
                textBoxConnectStatus.Text = "Connected";
                textBoxConnectStatus.BackColor = System.Drawing.Color.Green;
                textBoxConnectStatus2.Text = "Connected";
                textBoxConnectStatus2.BackColor = System.Drawing.Color.Green;
                textBoxConnectStatus3.Text = "Connected";
                textBoxConnectStatus3.BackColor = System.Drawing.Color.Green;

                comboBoxDAUfind.Enabled = false;
                comboBoxRDCfind.Enabled = false;

            }
            else
            {
                MessageBox.Show("Failed to connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            


            // Kode fra arbeidskrav 1
            /*
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
            }*/
        }


        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            textBoxConnectStatus.Text = "Not connected";
            textBoxConnectStatus.BackColor = System.Drawing.Color.Red;
            textBoxConnectStatus2.Text = "Not connected";
            textBoxConnectStatus2.BackColor = System.Drawing.Color.Red;
            textBoxConnectStatus3.Text = "Not connected";
            textBoxConnectStatus3.BackColor = System.Drawing.Color.Red;

            comboBoxDAUfind.Enabled = true;
            comboBoxRDCfind.Enabled = true;
            textBox_DAUConnect.Text = "";
            comboBoxPorts.Text = "";
            comboBoxBaud.Text = "";

            // Kode fra arbeidskrav 1
            /*
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

            }*/
        }


        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // Kode fra arbeidskrav 1
            /*
            if (SerialPort.IsOpen)
            {

                if (timerChartAdd.Enabled == true || timerSerialReceive.Enabled == true || timerStatus.Enabled == true || timerStatusReceive.Enabled == true)
                {
                    MessageBox.Show("Stop monitoring before loading config from instrument.", "Monitoring in progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
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
                        MessageBox.Show("Failed to load configuration from instrument. Setting to default values", "Read", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        instrumentConfigs = defaultConfig.Split(';');
                        textBoxTagname.Text = instrumentConfigs[0];
                        textBoxLRV.Text = instrumentConfigs[1];
                        textBoxURV.Text = instrumentConfigs[2];
                        textBoxAL.Text = instrumentConfigs[3];
                        textBoxAH.Text = instrumentConfigs[4];

                    }
                }  
            }
            else
            {
                MessageBox.Show("Please connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
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
                    MessageBox.Show("Not able to load data from file. Please try again", "Load from file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            // Kode fra arbeidskrav 1
            /*
            if (SerialPort.IsOpen)
            {

                if (timerChartAdd.Enabled == true || timerSerialReceive.Enabled == true || timerStatus.Enabled == true || timerStatusReceive.Enabled == true)
                {
                    MessageBox.Show("Stop monitoring before writing config to instrument", "Monitoring in progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
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


                            SerialPort.WriteLine(writeString);

                            Thread.Sleep(1200);                       // Venter på svar fra arduino
                            string confirmation;
                            confirmation = SerialPort.ReadExisting();

                            if (confirmation == "1")
                            {
                                MessageBox.Show("Config values successfully dowloaded to instrument", "Downloaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Wrong password", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
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
            // Kode fra arbeidskrav 1
            /*

            if (SerialPort.IsOpen)
            {
                if (comboBoxSignal.Text == "Raw")
                {
                    chartValues.Series[0].Name = "Raw";
                    SerialPort.WriteLine("readraw");
                }
                else if (comboBoxSignal.Text == "Scaled")
                {
                    chartValues.Series[0].Name = "Scaled";
                    SerialPort.WriteLine("readscaled");
                }

                timerSerialReceive.Enabled = true;
                timerChartAdd.Enabled = false;
                
            }*/
        }

        private void timerSerialReceive_Tick(object sender, EventArgs e)
        {
            // Kode fra arbeidskrav 1
            /*
            try
            {
                if (SerialPort.BytesToRead > 0)
                {
                    MeasurementPoint measuredPoint;
                    string availableData = "";
                    availableData = SerialPort.ReadExisting().ToString();

                    listBoxValues.Items.Insert(0, availableData);

                    if (comboBoxSignal.Text == "Raw")
                    {
                        measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), (availableData));
                        chartValues.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                        allMeasurementPoints.Add(measuredPoint);
                    }
                    else if (comboBoxSignal.Text == "Scaled")
                    {

                        measuredPoint = new MeasurementPoint(DateTime.Now.ToLongTimeString(), (availableData));
                        chartValues.Series[0].Points.AddXY(measuredPoint.time, measuredPoint.vab);
                        allMeasurementPoints.Add(measuredPoint);

                    }
                    timerStatus.Enabled = true;
                    timerSerialReceive.Enabled = false;
                }
            }
            catch (Exception)
            {
                
            }*/
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (textBoxConnectStatus2.Text == "Connected")
            {
                // Starter timer for simulering med loggeinterval basert på DAU
                timer_ChartSimulation.Interval = Convert.ToInt32(frequencyTextBox.Text);
                timer_ChartSimulation.Enabled = true;
                
                // Forhindrer at man kan endre instrument/DAU/RDC mens man logger
                comboBoxInstrumentfind.Enabled = false;
                comboBoxDAUfind.Enabled = false;
                comboBoxRDCfind.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please connect", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Kode fra arbeidskrav 1
            /*
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
            */
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {

            timer_ChartSimulation.Enabled = false;
            comboBoxInstrumentfind.Enabled = true;
            comboBoxDAUfind.Enabled = true;
            comboBoxRDCfind.Enabled = true;


            // Kode fra arbeidskrav 1
            /*
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
            */
        }

        public class MeasurementPoint
        {
            // Kode fra arbeidskrav 1
            /*
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
            }*/
        }
        
        
        private void timerStatus_Tick(object sender, EventArgs e)
        {
            // Kode fra arbeidskrav 1
            /*
            if (SerialPort.IsOpen)
            {
                SerialPort.WriteLine("readstatus");
            }

            timerStatusReceive.Enabled = true;
            timerStatus.Enabled = false;
            */
 
        }

        private void timerStatusReceive_Tick(object sender, EventArgs e)
        {
            // Kode fra arbeidskrav 1
            /*

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

               
            }*/
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            listBoxValues.Items.Clear();
            chartValues.Series[0].Points.Clear();
            textBoxStatus.Text = "";
            textBox_Digital_Log.Text = "";
            textBox_Digital_Log.BackColor = System.Drawing.Color.White;
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
            // Kode fra arbeidskrav 1
            /*
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
            }*/
        }

        private void buttonSaveGraph_Click(object sender, EventArgs e)
        {
            string filename;
            
            if (saveFileDialogGraph.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialogGraph.FileName;
                chartValues.SaveImage(filename, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);
                  
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Maker' table. You can move, or remove it, as needed.
            this.makerTableAdapter.Fill(this.instrument_databaseDataSet.Maker);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.LOG_DO' table. You can move, or remove it, as needed.
            this.lOG_DOTableAdapter.Fill(this.instrument_databaseDataSet.LOG_DO);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.LOG_DI' table. You can move, or remove it, as needed.
            this.lOG_DITableAdapter.Fill(this.instrument_databaseDataSet.LOG_DI);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.LOG_AO' table. You can move, or remove it, as needed.
            this.lOG_AOTableAdapter.Fill(this.instrument_databaseDataSet.LOG_AO);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet1.LOG_AI' table. You can move, or remove it, as needed.
            this.lOG_AITableAdapter.Fill(this.instrument_databaseDataSet1.LOG_AI);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.instrument_databaseDataSet.Model);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.instrument_databaseDataSet.Type);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Area_Instrument' table. You can move, or remove it, as needed.
            this.area_InstrumentTableAdapter.Fill(this.instrument_databaseDataSet.Area_Instrument);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.AD' table. You can move, or remove it, as needed.
            this.aDTableAdapter.Fill(this.instrument_databaseDataSet.AD);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.IO' table. You can move, or remove it, as needed.
            this.iOTableAdapter.Fill(this.instrument_databaseDataSet.IO);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet1.Instrument_combobox' table. You can move, or remove it, as needed.
            this.instrument_comboboxTableAdapter.Fill(this.instrument_databaseDataSet1.Instrument_combobox);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Instrument' table. You can move, or remove it, as needed.
            this.instrumentTableAdapter.Fill(this.instrument_databaseDataSet.Instrument);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.AreaDAU' table. You can move, or remove it, as needed.
            this.areaDAUTableAdapter.Fill(this.instrument_databaseDataSet.AreaDAU);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Communication' table. You can move, or remove it, as needed.
            this.communicationTableAdapter.Fill(this.instrument_databaseDataSet.Communication);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.Area' table. You can move, or remove it, as needed.
            this.areaTableAdapter.Fill(this.instrument_databaseDataSet.Area);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.RDC_combobox' table. You can move, or remove it, as needed.
            this.rDC_comboboxTableAdapter.Fill(this.instrument_databaseDataSet.RDC_combobox);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.DAU_combobox' table. You can move, or remove it, as needed.
            this.dAU_comboboxTableAdapter.Fill(this.instrument_databaseDataSet.DAU_combobox);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.RDC' table. You can move, or remove it, as needed.
            this.rDCTableAdapter.Fill(this.instrument_databaseDataSet.RDC);
            // TODO: This line of code loads data into the 'instrument_databaseDataSet.DAU' table. You can move, or remove it, as needed.
            this.dAUTableAdapter.Fill(this.instrument_databaseDataSet.DAU);

            int filterRDCID = Convert.ToInt32(comboBoxRDCfind.SelectedValue.ToString());
            rDCTableAdapter.FillByRDC(instrument_databaseDataSet.RDC, filterRDCID);
            dAU_comboboxTableAdapter.FillByDAUcombobox(instrument_databaseDataSet.DAU_combobox, filterRDCID);

            int filterDAUID = Convert.ToInt32(comboBoxDAUfind.SelectedValue.ToString());
            dAUTableAdapter.FillByDAUID(instrument_databaseDataSet.DAU, filterDAUID);
            instrument_comboboxTableAdapter.FillByInstrumentcombobox(instrument_databaseDataSet1.Instrument_combobox, filterDAUID);

            string filterInstrument = comboBoxInstrumentfind.SelectedValue.ToString();
            instrumentTableAdapter.FillByInstrument(instrument_databaseDataSet1.Instrument, filterInstrument);

        }

        private void comboBoxDAUfind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDAUfind.SelectedIndex > -1)
            {
                int filterDAUID = Convert.ToInt32(comboBoxDAUfind.SelectedValue.ToString());
                dAUTableAdapter.FillByDAUID(instrument_databaseDataSet.DAU, filterDAUID);
                instrument_comboboxTableAdapter.FillByInstrumentcombobox(instrument_databaseDataSet1.Instrument_combobox, filterDAUID);
            }
        }

        private void comboBoxRDCfind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRDCfind.SelectedIndex > -1)
            {
                int filterRDCID = Convert.ToInt32(comboBoxRDCfind.SelectedValue.ToString());
                rDCTableAdapter.FillByRDC(instrument_databaseDataSet.RDC, filterRDCID);
                dAU_comboboxTableAdapter.FillByDAUcombobox(instrument_databaseDataSet.DAU_combobox, filterRDCID);
                

                int filterDAUID = Convert.ToInt32(comboBoxDAUfind.SelectedValue.ToString());
                dAUTableAdapter.FillByDAUID(instrument_databaseDataSet.DAU, filterDAUID);
                instrument_comboboxTableAdapter.FillByInstrumentcombobox(instrument_databaseDataSet1.Instrument_combobox, filterDAUID);
            }
        }

        private void comboBoxInstrumentfind_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInstrumentfind.SelectedIndex > -1)
            {
                string filterInstrument = comboBoxInstrumentfind.SelectedValue.ToString();
                instrumentTableAdapter.FillByInstrument(instrument_databaseDataSet1.Instrument, filterInstrument);
            }
        }

        private void tabPage_Config_Enter(object sender, EventArgs e)
        {
            string filterInstrument = comboBoxInstrumentfind.SelectedValue.ToString();
            instrumentTableAdapter.FillByInstrument(instrument_databaseDataSet1.Instrument, filterInstrument);
        }

        private void button_Updatefrominstrument_Click(object sender, EventArgs e)
        {
            textBoxTagname.Text = comboBoxInstrumentfind.Text;
            textBoxLRV.Text = lRVTextBox.Text;
            textBoxURV.Text = uRVTextBox.Text;
            textBoxAL.Text = alarm_lowTextBox.Text;
            textBoxAH.Text = alarm_highTextBox.Text;
        }

        private void button_Savetodatabase_Click(object sender, EventArgs e)
        {
            if (textBoxTagname.Text == comboBoxInstrumentfind.Text)
            {
                if (textBoxLRV.Text == "" || textBoxURV.Text == "" || textBoxAL.Text == "" || textBoxAH.Text == "")
                {
                    MessageBox.Show("Enter all configurations", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lRVTextBox.Text = textBoxLRV.Text;
                    uRVTextBox.Text = textBoxURV.Text;
                    alarm_lowTextBox.Text = textBoxAL.Text;
                    alarm_highTextBox.Text = textBoxAH.Text;

                    instrumentBindingSource1.EndEdit();
                    instrumentTableAdapter.Update(instrument_databaseDataSet1.Instrument);

                    textBoxTagname.Clear();
                    textBoxLRV.Clear();
                    textBoxURV.Clear();
                    textBoxAL.Clear();
                    textBoxAH.Clear();

                    MessageBox.Show("Config successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("The tagnames need to correspond", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_TransfConnection_Click(object sender, EventArgs e)
        {
            comboBoxPorts.Text = cOMPortTextBox.Text;
            comboBoxBaud.Text = baud_rateTextBox.Text;
            textBox_DAUConnect.Text = comboBoxDAUfind.Text;
        }

        private void tabPage_LogData_Enter(object sender, EventArgs e)
        {
            // Endrer datagridview basert på instrumentet
            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Analog")
            {
                dataGridView_LOG.DataSource = lOG_AIBindingSource;
                label_LOG.Text = "Analog/Input";
                label_TagnameLog.Text = comboBoxInstrumentfind.Text;

                // Filtrerer loggetabellen basert på tagname
                string filterTagname = comboBoxInstrumentfind.SelectedValue.ToString();
                lOG_AITableAdapter.FillByTagname(instrument_databaseDataSet1.LOG_AI, filterTagname);

            }

            if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Analog")
            {
                dataGridView_LOG.DataSource = lOG_AOBindingSource;
                label_LOG.Text = "Analog/Output";
                label_TagnameLog.Text = comboBoxInstrumentfind.Text;

                // Filtrerer loggetabellen basert på tagname
                string filterTagname = comboBoxInstrumentfind.SelectedValue.ToString();
                lOG_AOTableAdapter.FillByTagname(instrument_databaseDataSet1.LOG_AO, filterTagname);

            }

            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Digital")
            {
                dataGridView_LOG.DataSource = lOG_DIBindingSource;
                label_LOG.Text = "Digital/Input";
                label_TagnameLog.Text = comboBoxInstrumentfind.Text;

                // Filtrerer loggetabellen basert på tagname
                string filterTagname = comboBoxInstrumentfind.SelectedValue.ToString();
                lOG_DITableAdapter.FillByTagname(instrument_databaseDataSet1.LOG_DI, filterTagname);

            }

            if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Digital")
            {
                dataGridView_LOG.DataSource = lOG_DOBindingSource;
                label_LOG.Text = "Digital/Output";
                label_TagnameLog.Text = comboBoxInstrumentfind.Text;

                // Filtrerer loggetabellen basert på tagname
                string filterTagname = comboBoxInstrumentfind.SelectedValue.ToString();
                lOG_DOTableAdapter.FillByTagname(instrument_databaseDataSet1.LOG_DO, filterTagname);
            }
        }

        private void timer_ChartSimulation_Tick(object sender, EventArgs e)
        {
            // Simulerer skalerte loggeverdier baser på LRV og URV
            string time = DateTime.Now.ToString("HH:mm:ss");
            Random rnd = new Random();
            int value_low = Convert.ToInt32(lRVTextBox.Text);
            int value_high = Convert.ToInt32(uRVTextBox.Text);
            int value = rnd.Next(value_low, value_high+1);

            // Analoge verdier sendes til graf mens digitale til tekstboks
            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Analog")
            {
                chartValues.Series[0].Points.AddXY(time, value);
            }
            else if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Analog")
            {
                chartValues.Series[0].Points.AddXY(time, value);
            }
            else
            {
                if (value == 0)
                {
                    textBox_Digital_Log.Text = "False";
                    textBox_Digital_Log.BackColor = System.Drawing.Color.Red;
                }
                if (value == 1)
                {
                    textBox_Digital_Log.Text = "True";
                    textBox_Digital_Log.BackColor = System.Drawing.Color.Green;
                }
            }
            
            listBoxValues.Items.Insert(0, value);

            int alarm_low = Convert.ToInt32(alarm_lowTextBox.Text);
            int alarm_high = Convert.ToInt32(alarm_highTextBox.Text);
            if (value > alarm_high)
            {
                textBoxStatus.Text = "Alarm high";
                textBoxStatus.BackColor = System.Drawing.Color.Red;
            }
            else if (value < alarm_low)
            {
                textBoxStatus.Text = "Alarm low";
                textBoxStatus.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                textBoxStatus.Text = "Ok";
                textBoxStatus.BackColor = System.Drawing.Color.White;
            }


            // Lagre loggedata fra input/analog til database
            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Analog")
            {
                try
                {
                    lOG_AIBindingSource.AddNew();
                    lOG_AIBindingSource.MoveLast();
                    textBox_TagAI.Text = comboBoxInstrumentfind.Text;
                    textBox_ValueAI.Text = value.ToString();
                    timeDateTimePicker_TagAI.Text = time;
                    textBox_ValueTypeAI.Text = "2";
                    lOG_AIBindingSource.EndEdit();
                    lOG_AITableAdapter.Update(instrument_databaseDataSet1.LOG_AI);
                }
                catch (Exception)
                {

                }                
            }

            // Lagre loggedata fra output/analog til database
            if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Analog")
            {
                try
                {
                    lOG_AOBindingSource.AddNew();
                    lOG_AOBindingSource.MoveLast();
                    textBox_TagAO.Text = comboBoxInstrumentfind.Text;
                    textBox_Value_AO.Text = value.ToString();
                    timeDateTimePicker_AO.Text = time;
                    timeDateTimePicker_OT_AO.Text = time;
                    textBox_VT_AO.Text = "2";
                    lOG_AOBindingSource.EndEdit();
                    lOG_AOTableAdapter.Update(instrument_databaseDataSet1.LOG_AO);
                }
                catch (Exception)
                {

                }
            }

            // Lagre loggedata fra input/digital til database
            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Digital")
            {
                try
                {
                    lOG_DIBindingSource.AddNew();
                    lOG_DIBindingSource.MoveLast();
                    textBox_TagDI.Text = comboBoxInstrumentfind.Text;
                    if (value == 0)
                    {
                        CheckBox_Value_DI.CheckState = CheckState.Unchecked;
                    }
                    if (value == 1)
                    {
                        CheckBox_Value_DI.CheckState = CheckState.Checked;
                    }
                    timeDateTimePicker_DI.Text = time;
                    lOG_DIBindingSource.EndEdit();
                    lOG_DITableAdapter.Update(instrument_databaseDataSet1.LOG_DI);
                }
                catch (Exception)
                {

                }                
            }

            // Lagre loggedata fra output/digital til database
            if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Digital")
            {
                try
                {
                    lOG_DOBindingSource.AddNew();
                    lOG_DOBindingSource.MoveLast();
                    textBox_TagDO.Text = comboBoxInstrumentfind.Text;
                    if (value == 0)
                    {
                        CheckBox_Value_DO.CheckState = CheckState.Unchecked;
                    }
                    if (value == 1)
                    {
                        CheckBox_Value_DO.CheckState = CheckState.Checked;
                    }
                    timeDateTimePicker_DO.Text = time;
                    timeDateTimePicker_OutputTime_DO.Text = time;
                    lOG_DOBindingSource.EndEdit();
                    lOG_DOTableAdapter.Update(instrument_databaseDataSet1.LOG_DO);
                }
                catch (Exception)
                {

                }                
            }
        }

        private void tabPage_Monitoring_Enter(object sender, EventArgs e)
        {
            chartValues.Series[0].Name = comboBoxInstrumentfind.Text;
            chartValues.ChartAreas[0].AxisX.Title = "Time";
            chartValues.ChartAreas[0].AxisY.Title = unitTextBox.Text;


            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Analog")
            {
                tabControl_Observation.SelectTab(tabPage_AI);
                panel_Digital_Log.Visible = false;
                chartValues.Visible = true;
                label_Analog_log.Text = descriptionTextBox.Text;
            }
            if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Analog")
            {
                tabControl_Observation.SelectTab(tabPage_AO);
                panel_Digital_Log.Visible = false;
                chartValues.Visible = true;
                label_Analog_log.Text = descriptionTextBox.Text;
            }
            if (comboBoxIO.Text == "Input" && comboBoxAD.Text == "Digital")
            {
                tabControl_Observation.SelectTab(tabPage_DI);
                panel_Digital_Log.Visible = true;
                chartValues.Visible = false;
                label_Digital_Log.Text = descriptionTextBox.Text;
                label_Analog_log.Text = "";
            }
            if (comboBoxIO.Text == "Output" && comboBoxAD.Text == "Digital")
            {
                tabControl_Observation.SelectTab(tabPage_DO);
                panel_Digital_Log.Visible = true;
                chartValues.Visible = false;
                label_Digital_Log.Text = descriptionTextBox.Text;
                label_Analog_log.Text = "";
            }


            lOG_AOBindingSource.MoveLast();
            lOG_AIBindingSource.MoveLast();
            lOG_DIBindingSource.MoveLast();
            lOG_DOBindingSource.MoveLast();
        }
    }
}
