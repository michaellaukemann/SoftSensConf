
namespace SoftSensConf
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxConnectStatus = new System.Windows.Forms.TextBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelComports = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxConnectStatus2 = new System.Windows.Forms.TextBox();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRW = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.labelTagname = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxConnectStatus3 = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.labelSensorSignal = new System.Windows.Forms.Label();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.labelValues = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogConfig = new System.Windows.Forms.OpenFileDialog();
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogData = new System.Windows.Forms.SaveFileDialog();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.timerStatusReceive = new System.Windows.Forms.Timer(this.components);
            this.timerConnection = new System.Windows.Forms.Timer(this.components);
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.saveFileDialogGraph = new System.Windows.Forms.SaveFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(984, 535);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxConnectStatus);
            this.tabPage1.Controls.Add(this.buttonAbout);
            this.tabPage1.Controls.Add(this.buttonDisconnect);
            this.tabPage1.Controls.Add(this.buttonConnect);
            this.tabPage1.Controls.Add(this.comboBoxBaud);
            this.tabPage1.Controls.Add(this.comboBoxPorts);
            this.tabPage1.Controls.Add(this.labelBaud);
            this.tabPage1.Controls.Add(this.labelComports);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxConnectStatus
            // 
            this.textBoxConnectStatus.BackColor = System.Drawing.Color.Red;
            this.textBoxConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus.Location = new System.Drawing.Point(763, 6);
            this.textBoxConnectStatus.Name = "textBoxConnectStatus";
            this.textBoxConnectStatus.ReadOnly = true;
            this.textBoxConnectStatus.Size = new System.Drawing.Size(207, 32);
            this.textBoxConnectStatus.TabIndex = 9;
            this.textBoxConnectStatus.TabStop = false;
            this.textBoxConnectStatus.Text = "Not connected";
            this.textBoxConnectStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAbout
            // 
            this.buttonAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAbout.Location = new System.Drawing.Point(876, 455);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(94, 39);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "&About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(351, 104);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(145, 37);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "&Disconnect";
            this.toolTip1.SetToolTip(this.buttonDisconnect, "Disconnect from the serial port");
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(351, 61);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(145, 37);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "&Connect";
            this.toolTip1.SetToolTip(this.buttonConnect, "Connect to the serial port");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "9600"});
            this.comboBoxBaud.Location = new System.Drawing.Point(186, 104);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBaud.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxBaud, "Choose baud rate");
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(186, 60);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPorts.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxPorts, "Choose com port");
            this.comboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(43, 104);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(79, 20);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baud rate";
            // 
            // labelComports
            // 
            this.labelComports.AutoSize = true;
            this.labelComports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComports.Location = new System.Drawing.Point(43, 60);
            this.labelComports.Name = "labelComports";
            this.labelComports.Size = new System.Drawing.Size(82, 20);
            this.labelComports.TabIndex = 0;
            this.labelComports.Text = "Com ports";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonOpen);
            this.tabPage2.Controls.Add(this.textBoxConnectStatus2);
            this.tabPage2.Controls.Add(this.textBoxAH);
            this.tabPage2.Controls.Add(this.textBoxAL);
            this.tabPage2.Controls.Add(this.textBoxURV);
            this.tabPage2.Controls.Add(this.textBoxLRV);
            this.tabPage2.Controls.Add(this.textBoxTagname);
            this.tabPage2.Controls.Add(this.labelAlarmH);
            this.tabPage2.Controls.Add(this.labelAlarmL);
            this.tabPage2.Controls.Add(this.labelURV);
            this.tabPage2.Controls.Add(this.labelLRW);
            this.tabPage2.Controls.Add(this.buttonSave);
            this.tabPage2.Controls.Add(this.buttonWrite);
            this.tabPage2.Controls.Add(this.buttonRead);
            this.tabPage2.Controls.Add(this.labelTagname);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpen.Location = new System.Drawing.Point(265, 290);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(106, 38);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "&Open";
            this.toolTip1.SetToolTip(this.buttonOpen, "Load configuration from file");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxConnectStatus2
            // 
            this.textBoxConnectStatus2.BackColor = System.Drawing.Color.Red;
            this.textBoxConnectStatus2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus2.Location = new System.Drawing.Point(763, 6);
            this.textBoxConnectStatus2.Name = "textBoxConnectStatus2";
            this.textBoxConnectStatus2.ReadOnly = true;
            this.textBoxConnectStatus2.Size = new System.Drawing.Size(207, 32);
            this.textBoxConnectStatus2.TabIndex = 8;
            this.textBoxConnectStatus2.TabStop = false;
            this.textBoxConnectStatus2.Text = "Not connected";
            this.textBoxConnectStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(265, 224);
            this.textBoxAH.MaxLength = 4;
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(234, 26);
            this.textBoxAH.TabIndex = 4;
            this.textBoxAH.Text = "440";
            this.textBoxAH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAH_KeyPress);
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(265, 178);
            this.textBoxAL.MaxLength = 4;
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(234, 26);
            this.textBoxAL.TabIndex = 3;
            this.textBoxAL.Text = "40";
            this.textBoxAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAL_KeyPress);
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(265, 130);
            this.textBoxURV.MaxLength = 7;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(234, 26);
            this.textBoxURV.TabIndex = 2;
            this.textBoxURV.Text = "500.0";
            this.textBoxURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURV_KeyPress);
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(265, 83);
            this.textBoxLRV.MaxLength = 7;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(234, 26);
            this.textBoxLRV.TabIndex = 1;
            this.textBoxLRV.Text = "0.0";
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Location = new System.Drawing.Point(265, 34);
            this.textBoxTagname.MaxLength = 10;
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.Size = new System.Drawing.Size(234, 26);
            this.textBoxTagname.TabIndex = 0;
            this.textBoxTagname.Text = "C385IT001";
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmH.Location = new System.Drawing.Point(18, 220);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(84, 20);
            this.labelAlarmH.TabIndex = 7;
            this.labelAlarmH.Text = "Alarm high";
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmL.Location = new System.Drawing.Point(18, 174);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(77, 20);
            this.labelAlarmL.TabIndex = 6;
            this.labelAlarmL.Text = "Alarm low";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(18, 126);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(139, 20);
            this.labelURV.TabIndex = 5;
            this.labelURV.Text = "Upper range value";
            // 
            // labelLRW
            // 
            this.labelLRW.AutoSize = true;
            this.labelLRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRW.Location = new System.Drawing.Point(18, 79);
            this.labelLRW.Name = "labelLRW";
            this.labelLRW.Size = new System.Drawing.Size(138, 20);
            this.labelLRW.TabIndex = 4;
            this.labelLRW.Text = "Lower range value";
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(393, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 38);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "&Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save configuration to file");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(538, 95);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(106, 38);
            this.buttonWrite.TabIndex = 6;
            this.buttonWrite.Text = "&Write";
            this.toolTip1.SetToolTip(this.buttonWrite, "Download the configuration to the instrument");
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(538, 34);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(106, 38);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "&Read";
            this.toolTip1.SetToolTip(this.buttonRead, "Load the current configuration on the instrument");
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelTagname
            // 
            this.labelTagname.AutoSize = true;
            this.labelTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagname.Location = new System.Drawing.Point(18, 32);
            this.labelTagname.Name = "labelTagname";
            this.labelTagname.Size = new System.Drawing.Size(76, 20);
            this.labelTagname.TabIndex = 0;
            this.labelTagname.Text = "Tagname";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSaveGraph);
            this.tabPage3.Controls.Add(this.textBoxConnectStatus3);
            this.tabPage3.Controls.Add(this.labelStatus);
            this.tabPage3.Controls.Add(this.buttonClearData);
            this.tabPage3.Controls.Add(this.labelSensorSignal);
            this.tabPage3.Controls.Add(this.comboBoxSignal);
            this.tabPage3.Controls.Add(this.textBoxStatus);
            this.tabPage3.Controls.Add(this.listBoxValues);
            this.tabPage3.Controls.Add(this.labelValues);
            this.tabPage3.Controls.Add(this.buttonStart);
            this.tabPage3.Controls.Add(this.buttonStop);
            this.tabPage3.Controls.Add(this.chartValues);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monitoring";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxConnectStatus3
            // 
            this.textBoxConnectStatus3.BackColor = System.Drawing.Color.Red;
            this.textBoxConnectStatus3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus3.Location = new System.Drawing.Point(763, 6);
            this.textBoxConnectStatus3.Name = "textBoxConnectStatus3";
            this.textBoxConnectStatus3.ReadOnly = true;
            this.textBoxConnectStatus3.Size = new System.Drawing.Size(207, 32);
            this.textBoxConnectStatus3.TabIndex = 13;
            this.textBoxConnectStatus3.TabStop = false;
            this.textBoxConnectStatus3.Text = "Not connected";
            this.textBoxConnectStatus3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(212, 185);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status";
            // 
            // buttonClearData
            // 
            this.buttonClearData.Location = new System.Drawing.Point(205, 104);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(75, 35);
            this.buttonClearData.TabIndex = 3;
            this.buttonClearData.Text = "&Clear";
            this.toolTip1.SetToolTip(this.buttonClearData, "Clear data");
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // labelSensorSignal
            // 
            this.labelSensorSignal.AutoSize = true;
            this.labelSensorSignal.Location = new System.Drawing.Point(15, 18);
            this.labelSensorSignal.Name = "labelSensorSignal";
            this.labelSensorSignal.Size = new System.Drawing.Size(143, 20);
            this.labelSensorSignal.TabIndex = 11;
            this.labelSensorSignal.Text = "Sensor signal type:";
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Items.AddRange(new object[] {
            "Raw",
            "Scaled"});
            this.comboBoxSignal.Location = new System.Drawing.Point(19, 51);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(172, 28);
            this.comboBoxSignal.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxSignal, "Choose sensor signal type");
            this.comboBoxSignal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSignal_KeyPress);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(194, 218);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(100, 26);
            this.textBoxStatus.TabIndex = 9;
            this.textBoxStatus.TabStop = false;
            this.textBoxStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxValues
            // 
            this.listBoxValues.ItemHeight = 20;
            this.listBoxValues.Location = new System.Drawing.Point(57, 218);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(82, 224);
            this.listBoxValues.TabIndex = 6;
            this.listBoxValues.TabStop = false;
            // 
            // labelValues
            // 
            this.labelValues.AutoSize = true;
            this.labelValues.Location = new System.Drawing.Point(65, 185);
            this.labelValues.Name = "labelValues";
            this.labelValues.Size = new System.Drawing.Size(58, 20);
            this.labelValues.TabIndex = 5;
            this.labelValues.Text = "Values";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(19, 104);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(77, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "&Start";
            this.toolTip1.SetToolTip(this.buttonStart, "Start monitoring");
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(114, 104);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(77, 35);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "S&top";
            this.toolTip1.SetToolTip(this.buttonStop, "Stop monitoring and save the data");
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // chartValues
            // 
            chartArea1.Name = "ChartArea1";
            this.chartValues.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartValues.Legends.Add(legend1);
            this.chartValues.Location = new System.Drawing.Point(320, 0);
            this.chartValues.Name = "chartValues";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Data";
            this.chartValues.Series.Add(series1);
            this.chartValues.Size = new System.Drawing.Size(656, 502);
            this.chartValues.TabIndex = 0;
            this.chartValues.TabStop = false;
            this.chartValues.Text = "chartInstrumentValues";
            title1.Name = "Title1";
            title2.Name = "Title2";
            title3.Name = "Title3";
            this.chartValues.Titles.Add(title1);
            this.chartValues.Titles.Add(title2);
            this.chartValues.Titles.Add(title3);
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM3";
            // 
            // saveFileDialogConfig
            // 
            this.saveFileDialogConfig.DefaultExt = "ssc";
            this.saveFileDialogConfig.FileName = "Config";
            // 
            // openFileDialogConfig
            // 
            this.openFileDialogConfig.DefaultExt = "ssc";
            // 
            // timerSerialReceive
            // 
            this.timerSerialReceive.Tick += new System.EventHandler(this.timerSerialReceive_Tick);
            // 
            // timerChartAdd
            // 
            this.timerChartAdd.Tick += new System.EventHandler(this.timerChartAdd_Tick);
            // 
            // saveFileDialogData
            // 
            this.saveFileDialogData.DefaultExt = "csv";
            this.saveFileDialogData.FileName = "Instrument values";
            // 
            // timerStatus
            // 
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // timerStatusReceive
            // 
            this.timerStatusReceive.Tick += new System.EventHandler(this.timerStatusReceive_Tick);
            // 
            // timerConnection
            // 
            this.timerConnection.Interval = 10;
            this.timerConnection.Tick += new System.EventHandler(this.timerConnection_Tick);
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(860, 459);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(108, 35);
            this.buttonSaveGraph.TabIndex = 14;
            this.buttonSaveGraph.Text = "S&ave graph";
            this.toolTip1.SetToolTip(this.buttonSaveGraph, "Save the graph as image");
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // saveFileDialogGraph
            // 
            this.saveFileDialogGraph.FileName = "Graph";
            this.saveFileDialogGraph.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 535);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelComports;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.Label labelAlarmH;
        private System.Windows.Forms.Label labelAlarmL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRW;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelTagname;
        private System.Windows.Forms.TextBox textBoxConnectStatus2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValues;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogConfig;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelValues;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Timer timerStatusReceive;
        private System.Windows.Forms.Label labelSensorSignal;
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxConnectStatus3;
        private System.Windows.Forms.TextBox textBoxConnectStatus;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGraph;
    }
}

