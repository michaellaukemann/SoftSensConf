
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
            System.Windows.Forms.Label area_IDLabel;
            System.Windows.Forms.Label DAULabel;
            System.Windows.Forms.Label communication_IDLabel;
            System.Windows.Forms.Label baud_rateLabel;
            System.Windows.Forms.Label cOMPortLabel;
            System.Windows.Forms.Label config_update_dateLabel;
            System.Windows.Forms.Label area_IDLabel1;
            System.Windows.Forms.Label iPaddressLabel;
            System.Windows.Forms.Label RDClabel;
            System.Windows.Forms.Label tagnameLabel;
            System.Windows.Forms.Label lRVLabel;
            System.Windows.Forms.Label uRVLabel;
            System.Windows.Forms.Label alarm_lowLabel;
            System.Windows.Forms.Label alarm_highLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label unitLabel;
            System.Windows.Forms.Label iO_IDLabel;
            System.Windows.Forms.Label aD_IDLabel;
            System.Windows.Forms.Label area_IDLabel2;
            System.Windows.Forms.Label type_IDLabel;
            System.Windows.Forms.Label model_IDLabel;
            System.Windows.Forms.Label observation_IDLabel;
            System.Windows.Forms.Label tagnameLabel1;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label value_type_IDLabel;
            System.Windows.Forms.Label observation_IDLabel1;
            System.Windows.Forms.Label tagnameLabel2;
            System.Windows.Forms.Label timeLabel1;
            System.Windows.Forms.Label value_type_IDLabel1;
            System.Windows.Forms.Label valueLabel1;
            System.Windows.Forms.Label output_timeLabel;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label observation_IDLabel2;
            System.Windows.Forms.Label tagnameLabel3;
            System.Windows.Forms.Label timeLabel2;
            System.Windows.Forms.Label valueLabel2;
            System.Windows.Forms.Label observation_IDLabel3;
            System.Windows.Forms.Label tagnameLabel4;
            System.Windows.Forms.Label timeLabel3;
            System.Windows.Forms.Label valueLabel3;
            System.Windows.Forms.Label output_timeLabel1;
            System.Windows.Forms.Label frequencyLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Connection = new System.Windows.Forms.TabPage();
            this.button_TransfConnection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_DAUConnect = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelComports = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_AreaRDC2 = new System.Windows.Forms.ComboBox();
            this.rDCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrument_databaseDataSet = new SoftSensConf.Instrument_databaseDataSet();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_AreaRDC = new System.Windows.Forms.ComboBox();
            this.comboBoxRDCfind = new System.Windows.Forms.ComboBox();
            this.rDCcomboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPaddressTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.dAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_AreaDAU2 = new System.Windows.Forms.ComboBox();
            this.areaDAUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSQL = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.communicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_AreaDAU = new System.Windows.Forms.ComboBox();
            this.comboBoxDAUfind = new System.Windows.Forms.ComboBox();
            this.dAUcomboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.config_update_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOMPortTextBox = new System.Windows.Forms.TextBox();
            this.baud_rateTextBox = new System.Windows.Forms.TextBox();
            this.textBoxConnectStatus = new System.Windows.Forms.TextBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.tabPage_Config = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Savetodatabase = new System.Windows.Forms.Button();
            this.button_Updatefrominstrument = new System.Windows.Forms.Button();
            this.labelTagname = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.labelLRW = new System.Windows.Forms.Label();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.labelURV = new System.Windows.Forms.Label();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_Maker = new System.Windows.Forms.ComboBox();
            this.instrumentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.instrument_databaseDataSet1 = new SoftSensConf.Instrument_databaseDataSet();
            this.makerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lRVTextBox = new System.Windows.Forms.TextBox();
            this.comboBox_Model = new System.Windows.Forms.ComboBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_AreaInstrument2 = new System.Windows.Forms.ComboBox();
            this.areaInstrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_AreaInstrument = new System.Windows.Forms.ComboBox();
            this.uRVTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxAD = new System.Windows.Forms.ComboBox();
            this.aDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxIO = new System.Windows.Forms.ComboBox();
            this.iOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarm_highTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.alarm_lowTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxInstrumentfind = new System.Windows.Forms.ComboBox();
            this.instrumentcomboboxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxConnectStatus2 = new System.Windows.Forms.TextBox();
            this.tabPage_Monitoring = new System.Windows.Forms.TabPage();
            this.panel_Digital_Log = new System.Windows.Forms.Panel();
            this.label_Digital_Log = new System.Windows.Forms.Label();
            this.tabControl_Observation = new System.Windows.Forms.TabControl();
            this.tabPage_AI = new System.Windows.Forms.TabPage();
            this.textBox_ValueAI = new System.Windows.Forms.TextBox();
            this.lOG_AIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeDateTimePicker_TagAI = new System.Windows.Forms.DateTimePicker();
            this.observation_IDTextBox = new System.Windows.Forms.TextBox();
            this.textBox_TagAI = new System.Windows.Forms.TextBox();
            this.textBox_ValueTypeAI = new System.Windows.Forms.TextBox();
            this.tabPage_AO = new System.Windows.Forms.TabPage();
            this.observation_IDTextBox1 = new System.Windows.Forms.TextBox();
            this.lOG_AOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_TagAO = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker_AO = new System.Windows.Forms.DateTimePicker();
            this.textBox_VT_AO = new System.Windows.Forms.TextBox();
            this.textBox_Value_AO = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker_OT_AO = new System.Windows.Forms.DateTimePicker();
            this.tabPage_DI = new System.Windows.Forms.TabPage();
            this.observation_IDTextBox2 = new System.Windows.Forms.TextBox();
            this.lOG_DIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_TagDI = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker_DI = new System.Windows.Forms.DateTimePicker();
            this.CheckBox_Value_DI = new System.Windows.Forms.CheckBox();
            this.tabPage_DO = new System.Windows.Forms.TabPage();
            this.observation_IDTextBox3 = new System.Windows.Forms.TextBox();
            this.lOG_DOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_TagDO = new System.Windows.Forms.TextBox();
            this.timeDateTimePicker_DO = new System.Windows.Forms.DateTimePicker();
            this.CheckBox_Value_DO = new System.Windows.Forms.CheckBox();
            this.timeDateTimePicker_OutputTime_DO = new System.Windows.Forms.DateTimePicker();
            this.label_Observation_AI = new System.Windows.Forms.Label();
            this.buttonSaveGraph = new System.Windows.Forms.Button();
            this.textBoxConnectStatus3 = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.labelValues = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.chartValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage_LogData = new System.Windows.Forms.TabPage();
            this.label_TagnameLog = new System.Windows.Forms.Label();
            this.label_LOG = new System.Windows.Forms.Label();
            this.dataGridView_LOG = new System.Windows.Forms.DataGridView();
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
            this.saveFileDialogGraph = new System.Windows.Forms.SaveFileDialog();
            this.lOGAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGDIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timer_ChartSimulation = new System.Windows.Forms.Timer(this.components);
            this.timer_StatusSimulation = new System.Windows.Forms.Timer(this.components);
            this.instrumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dAUTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.DAUTableAdapter();
            this.tableAdapterManager = new SoftSensConf.Instrument_databaseDataSetTableAdapters.TableAdapterManager();
            this.rDCTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.RDCTableAdapter();
            this.dAU_comboboxTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.DAU_comboboxTableAdapter();
            this.rDC_comboboxTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.RDC_comboboxTableAdapter();
            this.areaTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.AreaTableAdapter();
            this.communicationTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.CommunicationTableAdapter();
            this.areaDAUTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.AreaDAUTableAdapter();
            this.instrumentTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.InstrumentTableAdapter();
            this.instrument_comboboxTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.Instrument_comboboxTableAdapter();
            this.iOTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.IOTableAdapter();
            this.aDTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.ADTableAdapter();
            this.area_InstrumentTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.Area_InstrumentTableAdapter();
            this.typeTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.TypeTableAdapter();
            this.modelTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.ModelTableAdapter();
            this.lOG_AITableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.LOG_AITableAdapter();
            this.lOG_AOTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.LOG_AOTableAdapter();
            this.lOG_DITableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.LOG_DITableAdapter();
            this.lOG_DOTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.LOG_DOTableAdapter();
            this.makerTableAdapter = new SoftSensConf.Instrument_databaseDataSetTableAdapters.MakerTableAdapter();
            this.dAUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_Analog_log = new System.Windows.Forms.Label();
            this.textBox_Digital_Log = new System.Windows.Forms.TextBox();
            area_IDLabel = new System.Windows.Forms.Label();
            DAULabel = new System.Windows.Forms.Label();
            communication_IDLabel = new System.Windows.Forms.Label();
            baud_rateLabel = new System.Windows.Forms.Label();
            cOMPortLabel = new System.Windows.Forms.Label();
            config_update_dateLabel = new System.Windows.Forms.Label();
            area_IDLabel1 = new System.Windows.Forms.Label();
            iPaddressLabel = new System.Windows.Forms.Label();
            RDClabel = new System.Windows.Forms.Label();
            tagnameLabel = new System.Windows.Forms.Label();
            lRVLabel = new System.Windows.Forms.Label();
            uRVLabel = new System.Windows.Forms.Label();
            alarm_lowLabel = new System.Windows.Forms.Label();
            alarm_highLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            iO_IDLabel = new System.Windows.Forms.Label();
            aD_IDLabel = new System.Windows.Forms.Label();
            area_IDLabel2 = new System.Windows.Forms.Label();
            type_IDLabel = new System.Windows.Forms.Label();
            model_IDLabel = new System.Windows.Forms.Label();
            observation_IDLabel = new System.Windows.Forms.Label();
            tagnameLabel1 = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            value_type_IDLabel = new System.Windows.Forms.Label();
            observation_IDLabel1 = new System.Windows.Forms.Label();
            tagnameLabel2 = new System.Windows.Forms.Label();
            timeLabel1 = new System.Windows.Forms.Label();
            value_type_IDLabel1 = new System.Windows.Forms.Label();
            valueLabel1 = new System.Windows.Forms.Label();
            output_timeLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            observation_IDLabel2 = new System.Windows.Forms.Label();
            tagnameLabel3 = new System.Windows.Forms.Label();
            timeLabel2 = new System.Windows.Forms.Label();
            valueLabel2 = new System.Windows.Forms.Label();
            observation_IDLabel3 = new System.Windows.Forms.Label();
            tagnameLabel4 = new System.Windows.Forms.Label();
            timeLabel3 = new System.Windows.Forms.Label();
            valueLabel3 = new System.Windows.Forms.Label();
            output_timeLabel1 = new System.Windows.Forms.Label();
            frequencyLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage_Connection.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCcomboboxBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDAUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUcomboboxBindingSource)).BeginInit();
            this.tabPage_Config.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaInstrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentcomboboxBindingSource)).BeginInit();
            this.tabPage_Monitoring.SuspendLayout();
            this.panel_Digital_Log.SuspendLayout();
            this.tabControl_Observation.SuspendLayout();
            this.tabPage_AI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_AIBindingSource)).BeginInit();
            this.tabPage_AO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_AOBindingSource)).BeginInit();
            this.tabPage_DI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_DIBindingSource)).BeginInit();
            this.tabPage_DO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_DOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).BeginInit();
            this.tabPage_LogData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGDIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // area_IDLabel
            // 
            area_IDLabel.AutoSize = true;
            area_IDLabel.Location = new System.Drawing.Point(31, 60);
            area_IDLabel.Name = "area_IDLabel";
            area_IDLabel.Size = new System.Drawing.Size(74, 20);
            area_IDLabel.TabIndex = 13;
            area_IDLabel.Text = "Location:";
            // 
            // DAULabel
            // 
            DAULabel.AutoSize = true;
            DAULabel.Location = new System.Drawing.Point(31, 31);
            DAULabel.Name = "DAULabel";
            DAULabel.Size = new System.Drawing.Size(48, 20);
            DAULabel.TabIndex = 15;
            DAULabel.Text = "DAU:";
            // 
            // communication_IDLabel
            // 
            communication_IDLabel.AutoSize = true;
            communication_IDLabel.Location = new System.Drawing.Point(31, 125);
            communication_IDLabel.Name = "communication_IDLabel";
            communication_IDLabel.Size = new System.Drawing.Size(80, 20);
            communication_IDLabel.TabIndex = 17;
            communication_IDLabel.Text = "Com type:";
            // 
            // baud_rateLabel
            // 
            baud_rateLabel.AutoSize = true;
            baud_rateLabel.Location = new System.Drawing.Point(31, 157);
            baud_rateLabel.Name = "baud_rateLabel";
            baud_rateLabel.Size = new System.Drawing.Size(83, 20);
            baud_rateLabel.TabIndex = 19;
            baud_rateLabel.Text = "Baud rate:";
            // 
            // cOMPortLabel
            // 
            cOMPortLabel.AutoSize = true;
            cOMPortLabel.Location = new System.Drawing.Point(31, 189);
            cOMPortLabel.Name = "cOMPortLabel";
            cOMPortLabel.Size = new System.Drawing.Size(78, 20);
            cOMPortLabel.TabIndex = 21;
            cOMPortLabel.Text = "Com port:";
            // 
            // config_update_dateLabel
            // 
            config_update_dateLabel.AutoSize = true;
            config_update_dateLabel.Location = new System.Drawing.Point(31, 222);
            config_update_dateLabel.Name = "config_update_dateLabel";
            config_update_dateLabel.Size = new System.Drawing.Size(149, 20);
            config_update_dateLabel.TabIndex = 23;
            config_update_dateLabel.Text = "Config update date:";
            // 
            // area_IDLabel1
            // 
            area_IDLabel1.AutoSize = true;
            area_IDLabel1.Location = new System.Drawing.Point(32, 57);
            area_IDLabel1.Name = "area_IDLabel1";
            area_IDLabel1.Size = new System.Drawing.Size(74, 20);
            area_IDLabel1.TabIndex = 29;
            area_IDLabel1.Text = "Location:";
            // 
            // iPaddressLabel
            // 
            iPaddressLabel.AutoSize = true;
            iPaddressLabel.Location = new System.Drawing.Point(32, 121);
            iPaddressLabel.Name = "iPaddressLabel";
            iPaddressLabel.Size = new System.Drawing.Size(91, 20);
            iPaddressLabel.TabIndex = 33;
            iPaddressLabel.Text = "IP Address:";
            // 
            // RDClabel
            // 
            RDClabel.AutoSize = true;
            RDClabel.Location = new System.Drawing.Point(32, 28);
            RDClabel.Name = "RDClabel";
            RDClabel.Size = new System.Drawing.Size(48, 20);
            RDClabel.TabIndex = 28;
            RDClabel.Text = "RDC:";
            // 
            // tagnameLabel
            // 
            tagnameLabel.AutoSize = true;
            tagnameLabel.Location = new System.Drawing.Point(23, 39);
            tagnameLabel.Name = "tagnameLabel";
            tagnameLabel.Size = new System.Drawing.Size(80, 20);
            tagnameLabel.TabIndex = 15;
            tagnameLabel.Text = "Tagname:";
            // 
            // lRVLabel
            // 
            lRVLabel.AutoSize = true;
            lRVLabel.Location = new System.Drawing.Point(23, 396);
            lRVLabel.Name = "lRVLabel";
            lRVLabel.Size = new System.Drawing.Size(45, 20);
            lRVLabel.TabIndex = 47;
            lRVLabel.Text = "LRV:";
            // 
            // uRVLabel
            // 
            uRVLabel.AutoSize = true;
            uRVLabel.Location = new System.Drawing.Point(23, 428);
            uRVLabel.Name = "uRVLabel";
            uRVLabel.Size = new System.Drawing.Size(48, 20);
            uRVLabel.TabIndex = 49;
            uRVLabel.Text = "URV:";
            // 
            // alarm_lowLabel
            // 
            alarm_lowLabel.AutoSize = true;
            alarm_lowLabel.Location = new System.Drawing.Point(23, 460);
            alarm_lowLabel.Name = "alarm_lowLabel";
            alarm_lowLabel.Size = new System.Drawing.Size(81, 20);
            alarm_lowLabel.TabIndex = 51;
            alarm_lowLabel.Text = "Alarm low:";
            // 
            // alarm_highLabel
            // 
            alarm_highLabel.AutoSize = true;
            alarm_highLabel.Location = new System.Drawing.Point(23, 492);
            alarm_highLabel.Name = "alarm_highLabel";
            alarm_highLabel.Size = new System.Drawing.Size(88, 20);
            alarm_highLabel.TabIndex = 53;
            alarm_highLabel.Text = "Alarm high:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(23, 75);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 55;
            descriptionLabel.Text = "Description:";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(23, 110);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(42, 20);
            unitLabel.TabIndex = 57;
            unitLabel.Text = "Unit:";
            // 
            // iO_IDLabel
            // 
            iO_IDLabel.AutoSize = true;
            iO_IDLabel.Location = new System.Drawing.Point(23, 210);
            iO_IDLabel.Name = "iO_IDLabel";
            iO_IDLabel.Size = new System.Drawing.Size(30, 20);
            iO_IDLabel.TabIndex = 59;
            iO_IDLabel.Text = "IO:";
            // 
            // aD_IDLabel
            // 
            aD_IDLabel.AutoSize = true;
            aD_IDLabel.Location = new System.Drawing.Point(23, 247);
            aD_IDLabel.Name = "aD_IDLabel";
            aD_IDLabel.Size = new System.Drawing.Size(36, 20);
            aD_IDLabel.TabIndex = 61;
            aD_IDLabel.Text = "AD:";
            // 
            // area_IDLabel2
            // 
            area_IDLabel2.AutoSize = true;
            area_IDLabel2.Location = new System.Drawing.Point(23, 143);
            area_IDLabel2.Name = "area_IDLabel2";
            area_IDLabel2.Size = new System.Drawing.Size(74, 20);
            area_IDLabel2.TabIndex = 63;
            area_IDLabel2.Text = "Location:";
            // 
            // type_IDLabel
            // 
            type_IDLabel.AutoSize = true;
            type_IDLabel.Location = new System.Drawing.Point(23, 280);
            type_IDLabel.Name = "type_IDLabel";
            type_IDLabel.Size = new System.Drawing.Size(47, 20);
            type_IDLabel.TabIndex = 65;
            type_IDLabel.Text = "Type:";
            // 
            // model_IDLabel
            // 
            model_IDLabel.AutoSize = true;
            model_IDLabel.Location = new System.Drawing.Point(23, 348);
            model_IDLabel.Name = "model_IDLabel";
            model_IDLabel.Size = new System.Drawing.Size(56, 20);
            model_IDLabel.TabIndex = 67;
            model_IDLabel.Text = "Model:";
            // 
            // observation_IDLabel
            // 
            observation_IDLabel.AutoSize = true;
            observation_IDLabel.Location = new System.Drawing.Point(24, 23);
            observation_IDLabel.Name = "observation_IDLabel";
            observation_IDLabel.Size = new System.Drawing.Size(119, 20);
            observation_IDLabel.TabIndex = 15;
            observation_IDLabel.Text = "Observation ID:";
            // 
            // tagnameLabel1
            // 
            tagnameLabel1.AutoSize = true;
            tagnameLabel1.Location = new System.Drawing.Point(24, 55);
            tagnameLabel1.Name = "tagnameLabel1";
            tagnameLabel1.Size = new System.Drawing.Size(80, 20);
            tagnameLabel1.TabIndex = 17;
            tagnameLabel1.Text = "Tagname:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(24, 88);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(47, 20);
            timeLabel.TabIndex = 19;
            timeLabel.Text = "Time:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(24, 151);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(54, 20);
            valueLabel.TabIndex = 23;
            valueLabel.Text = "Value:";
            // 
            // value_type_IDLabel
            // 
            value_type_IDLabel.AutoSize = true;
            value_type_IDLabel.Location = new System.Drawing.Point(24, 119);
            value_type_IDLabel.Name = "value_type_IDLabel";
            value_type_IDLabel.Size = new System.Drawing.Size(109, 20);
            value_type_IDLabel.TabIndex = 21;
            value_type_IDLabel.Text = "Value type ID:";
            // 
            // observation_IDLabel1
            // 
            observation_IDLabel1.AutoSize = true;
            observation_IDLabel1.Location = new System.Drawing.Point(24, 23);
            observation_IDLabel1.Name = "observation_IDLabel1";
            observation_IDLabel1.Size = new System.Drawing.Size(119, 20);
            observation_IDLabel1.TabIndex = 0;
            observation_IDLabel1.Text = "Observation ID:";
            // 
            // tagnameLabel2
            // 
            tagnameLabel2.AutoSize = true;
            tagnameLabel2.Location = new System.Drawing.Point(24, 55);
            tagnameLabel2.Name = "tagnameLabel2";
            tagnameLabel2.Size = new System.Drawing.Size(80, 20);
            tagnameLabel2.TabIndex = 2;
            tagnameLabel2.Text = "Tagname:";
            // 
            // timeLabel1
            // 
            timeLabel1.AutoSize = true;
            timeLabel1.Location = new System.Drawing.Point(24, 88);
            timeLabel1.Name = "timeLabel1";
            timeLabel1.Size = new System.Drawing.Size(47, 20);
            timeLabel1.TabIndex = 4;
            timeLabel1.Text = "Time:";
            // 
            // value_type_IDLabel1
            // 
            value_type_IDLabel1.AutoSize = true;
            value_type_IDLabel1.Location = new System.Drawing.Point(24, 119);
            value_type_IDLabel1.Name = "value_type_IDLabel1";
            value_type_IDLabel1.Size = new System.Drawing.Size(109, 20);
            value_type_IDLabel1.TabIndex = 6;
            value_type_IDLabel1.Text = "Value type ID:";
            // 
            // valueLabel1
            // 
            valueLabel1.AutoSize = true;
            valueLabel1.Location = new System.Drawing.Point(24, 151);
            valueLabel1.Name = "valueLabel1";
            valueLabel1.Size = new System.Drawing.Size(54, 20);
            valueLabel1.TabIndex = 8;
            valueLabel1.Text = "Value:";
            // 
            // output_timeLabel
            // 
            output_timeLabel.AutoSize = true;
            output_timeLabel.Location = new System.Drawing.Point(24, 184);
            output_timeLabel.Name = "output_timeLabel";
            output_timeLabel.Size = new System.Drawing.Size(96, 20);
            output_timeLabel.TabIndex = 10;
            output_timeLabel.Text = "Output time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(23, 315);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(57, 20);
            label7.TabIndex = 77;
            label7.Text = "Maker:";
            // 
            // observation_IDLabel2
            // 
            observation_IDLabel2.AutoSize = true;
            observation_IDLabel2.Location = new System.Drawing.Point(24, 23);
            observation_IDLabel2.Name = "observation_IDLabel2";
            observation_IDLabel2.Size = new System.Drawing.Size(119, 20);
            observation_IDLabel2.TabIndex = 0;
            observation_IDLabel2.Text = "Observation ID:";
            // 
            // tagnameLabel3
            // 
            tagnameLabel3.AutoSize = true;
            tagnameLabel3.Location = new System.Drawing.Point(24, 55);
            tagnameLabel3.Name = "tagnameLabel3";
            tagnameLabel3.Size = new System.Drawing.Size(80, 20);
            tagnameLabel3.TabIndex = 2;
            tagnameLabel3.Text = "Tagname:";
            // 
            // timeLabel2
            // 
            timeLabel2.AutoSize = true;
            timeLabel2.Location = new System.Drawing.Point(24, 88);
            timeLabel2.Name = "timeLabel2";
            timeLabel2.Size = new System.Drawing.Size(47, 20);
            timeLabel2.TabIndex = 4;
            timeLabel2.Text = "Time:";
            // 
            // valueLabel2
            // 
            valueLabel2.AutoSize = true;
            valueLabel2.Location = new System.Drawing.Point(24, 121);
            valueLabel2.Name = "valueLabel2";
            valueLabel2.Size = new System.Drawing.Size(54, 20);
            valueLabel2.TabIndex = 6;
            valueLabel2.Text = "Value:";
            // 
            // observation_IDLabel3
            // 
            observation_IDLabel3.AutoSize = true;
            observation_IDLabel3.Location = new System.Drawing.Point(24, 23);
            observation_IDLabel3.Name = "observation_IDLabel3";
            observation_IDLabel3.Size = new System.Drawing.Size(119, 20);
            observation_IDLabel3.TabIndex = 0;
            observation_IDLabel3.Text = "Observation ID:";
            // 
            // tagnameLabel4
            // 
            tagnameLabel4.AutoSize = true;
            tagnameLabel4.Location = new System.Drawing.Point(24, 55);
            tagnameLabel4.Name = "tagnameLabel4";
            tagnameLabel4.Size = new System.Drawing.Size(80, 20);
            tagnameLabel4.TabIndex = 2;
            tagnameLabel4.Text = "Tagname:";
            // 
            // timeLabel3
            // 
            timeLabel3.AutoSize = true;
            timeLabel3.Location = new System.Drawing.Point(24, 88);
            timeLabel3.Name = "timeLabel3";
            timeLabel3.Size = new System.Drawing.Size(47, 20);
            timeLabel3.TabIndex = 4;
            timeLabel3.Text = "Time:";
            // 
            // valueLabel3
            // 
            valueLabel3.AutoSize = true;
            valueLabel3.Location = new System.Drawing.Point(24, 121);
            valueLabel3.Name = "valueLabel3";
            valueLabel3.Size = new System.Drawing.Size(54, 20);
            valueLabel3.TabIndex = 6;
            valueLabel3.Text = "Value:";
            // 
            // output_timeLabel1
            // 
            output_timeLabel1.AutoSize = true;
            output_timeLabel1.Location = new System.Drawing.Point(24, 151);
            output_timeLabel1.Name = "output_timeLabel1";
            output_timeLabel1.Size = new System.Drawing.Size(96, 20);
            output_timeLabel1.TabIndex = 8;
            output_timeLabel1.Text = "Output time:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Location = new System.Drawing.Point(32, 254);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new System.Drawing.Size(94, 20);
            frequencyLabel.TabIndex = 38;
            frequencyLabel.Text = "Log interval:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Connection);
            this.tabControl.Controls.Add(this.tabPage_Config);
            this.tabControl.Controls.Add(this.tabPage_Monitoring);
            this.tabControl.Controls.Add(this.tabPage_LogData);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1031, 710);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_Connection
            // 
            this.tabPage_Connection.AutoScroll = true;
            this.tabPage_Connection.Controls.Add(this.button_TransfConnection);
            this.tabPage_Connection.Controls.Add(this.label3);
            this.tabPage_Connection.Controls.Add(this.panel5);
            this.tabPage_Connection.Controls.Add(this.label2);
            this.tabPage_Connection.Controls.Add(this.label1);
            this.tabPage_Connection.Controls.Add(this.panel2);
            this.tabPage_Connection.Controls.Add(this.panel1);
            this.tabPage_Connection.Controls.Add(this.textBoxConnectStatus);
            this.tabPage_Connection.Controls.Add(this.buttonAbout);
            this.tabPage_Connection.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Connection.Name = "tabPage_Connection";
            this.tabPage_Connection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Connection.Size = new System.Drawing.Size(1023, 677);
            this.tabPage_Connection.TabIndex = 0;
            this.tabPage_Connection.Text = "Connection";
            this.tabPage_Connection.UseVisualStyleBackColor = true;
            // 
            // button_TransfConnection
            // 
            this.button_TransfConnection.Location = new System.Drawing.Point(468, 336);
            this.button_TransfConnection.Name = "button_TransfConnection";
            this.button_TransfConnection.Size = new System.Drawing.Size(87, 66);
            this.button_TransfConnection.TabIndex = 40;
            this.button_TransfConnection.Text = "Transfer -->";
            this.button_TransfConnection.UseVisualStyleBackColor = true;
            this.button_TransfConnection.Click += new System.EventHandler(this.button_TransfConnection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(712, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Connect";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox_DAUConnect);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.labelComports);
            this.panel5.Controls.Add(this.labelBaud);
            this.panel5.Controls.Add(this.comboBoxPorts);
            this.panel5.Controls.Add(this.comboBoxBaud);
            this.panel5.Controls.Add(this.buttonConnect);
            this.panel5.Controls.Add(this.buttonDisconnect);
            this.panel5.Location = new System.Drawing.Point(568, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 168);
            this.panel5.TabIndex = 38;
            // 
            // textBox_DAUConnect
            // 
            this.textBox_DAUConnect.Enabled = false;
            this.textBox_DAUConnect.Location = new System.Drawing.Point(101, 25);
            this.textBox_DAUConnect.Name = "textBox_DAUConnect";
            this.textBox_DAUConnect.Size = new System.Drawing.Size(121, 26);
            this.textBox_DAUConnect.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "DAU";
            // 
            // labelComports
            // 
            this.labelComports.AutoSize = true;
            this.labelComports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComports.Location = new System.Drawing.Point(3, 69);
            this.labelComports.Name = "labelComports";
            this.labelComports.Size = new System.Drawing.Size(82, 20);
            this.labelComports.TabIndex = 0;
            this.labelComports.Text = "Com ports";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaud.Location = new System.Drawing.Point(3, 114);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(79, 20);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "Baud rate";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Enabled = false;
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(101, 69);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPorts.TabIndex = 2;
            this.toolTip1.SetToolTip(this.comboBoxPorts, "Choose com port");
            this.comboBoxPorts.Enter += new System.EventHandler(this.comboBoxPorts_Enter);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.Enabled = false;
            this.comboBoxBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "9600"});
            this.comboBoxBaud.Location = new System.Drawing.Point(101, 114);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBaud.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxBaud, "Choose baud rate");
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.Location = new System.Drawing.Point(239, 25);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(146, 37);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "&Connect";
            this.toolTip1.SetToolTip(this.buttonConnect, "Connect to the serial port");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.Location = new System.Drawing.Point(239, 68);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(146, 37);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "&Disconnect";
            this.toolTip1.SetToolTip(this.buttonDisconnect, "Disconnect from the serial port");
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Data Aquisition Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Remote Data Collector";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox_AreaRDC2);
            this.panel2.Controls.Add(this.comboBox_AreaRDC);
            this.panel2.Controls.Add(this.comboBoxRDCfind);
            this.panel2.Controls.Add(RDClabel);
            this.panel2.Controls.Add(this.iPaddressTextBox);
            this.panel2.Controls.Add(iPaddressLabel);
            this.panel2.Controls.Add(area_IDLabel1);
            this.panel2.Location = new System.Drawing.Point(8, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 168);
            this.panel2.TabIndex = 35;
            // 
            // comboBox_AreaRDC2
            // 
            this.comboBox_AreaRDC2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rDCBindingSource, "Area_ID", true));
            this.comboBox_AreaRDC2.DataSource = this.areaBindingSource;
            this.comboBox_AreaRDC2.DisplayMember = "Description";
            this.comboBox_AreaRDC2.Enabled = false;
            this.comboBox_AreaRDC2.FormattingEnabled = true;
            this.comboBox_AreaRDC2.Location = new System.Drawing.Point(186, 84);
            this.comboBox_AreaRDC2.Name = "comboBox_AreaRDC2";
            this.comboBox_AreaRDC2.Size = new System.Drawing.Size(200, 28);
            this.comboBox_AreaRDC2.TabIndex = 36;
            this.comboBox_AreaRDC2.ValueMember = "Area_ID";
            // 
            // rDCBindingSource
            // 
            this.rDCBindingSource.DataMember = "RDC";
            this.rDCBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // instrument_databaseDataSet
            // 
            this.instrument_databaseDataSet.DataSetName = "Instrument_databaseDataSet";
            this.instrument_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // comboBox_AreaRDC
            // 
            this.comboBox_AreaRDC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rDCBindingSource, "Area_ID", true));
            this.comboBox_AreaRDC.DataSource = this.areaBindingSource;
            this.comboBox_AreaRDC.DisplayMember = "Location";
            this.comboBox_AreaRDC.Enabled = false;
            this.comboBox_AreaRDC.FormattingEnabled = true;
            this.comboBox_AreaRDC.Location = new System.Drawing.Point(186, 51);
            this.comboBox_AreaRDC.Name = "comboBox_AreaRDC";
            this.comboBox_AreaRDC.Size = new System.Drawing.Size(200, 28);
            this.comboBox_AreaRDC.TabIndex = 35;
            this.comboBox_AreaRDC.ValueMember = "Area_ID";
            // 
            // comboBoxRDCfind
            // 
            this.comboBoxRDCfind.DataSource = this.rDCcomboboxBindingSource;
            this.comboBoxRDCfind.DisplayMember = "Description";
            this.comboBoxRDCfind.FormattingEnabled = true;
            this.comboBoxRDCfind.Location = new System.Drawing.Point(186, 20);
            this.comboBoxRDCfind.Name = "comboBoxRDCfind";
            this.comboBoxRDCfind.Size = new System.Drawing.Size(200, 28);
            this.comboBoxRDCfind.TabIndex = 29;
            this.comboBoxRDCfind.ValueMember = "RDC_ID";
            this.comboBoxRDCfind.SelectedIndexChanged += new System.EventHandler(this.comboBoxRDCfind_SelectedIndexChanged);
            // 
            // rDCcomboboxBindingSource
            // 
            this.rDCcomboboxBindingSource.DataMember = "RDC_combobox";
            this.rDCcomboboxBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // iPaddressTextBox
            // 
            this.iPaddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rDCBindingSource, "IPaddress", true));
            this.iPaddressTextBox.Enabled = false;
            this.iPaddressTextBox.Location = new System.Drawing.Point(186, 115);
            this.iPaddressTextBox.Name = "iPaddressTextBox";
            this.iPaddressTextBox.Size = new System.Drawing.Size(200, 26);
            this.iPaddressTextBox.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(frequencyLabel);
            this.panel1.Controls.Add(this.frequencyTextBox);
            this.panel1.Controls.Add(this.comboBox_AreaDAU2);
            this.panel1.Controls.Add(this.comboBoxCOM);
            this.panel1.Controls.Add(this.comboBox_AreaDAU);
            this.panel1.Controls.Add(this.comboBoxDAUfind);
            this.panel1.Controls.Add(this.config_update_dateDateTimePicker);
            this.panel1.Controls.Add(config_update_dateLabel);
            this.panel1.Controls.Add(area_IDLabel);
            this.panel1.Controls.Add(this.cOMPortTextBox);
            this.panel1.Controls.Add(cOMPortLabel);
            this.panel1.Controls.Add(DAULabel);
            this.panel1.Controls.Add(this.baud_rateTextBox);
            this.panel1.Controls.Add(baud_rateLabel);
            this.panel1.Controls.Add(communication_IDLabel);
            this.panel1.Location = new System.Drawing.Point(8, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 315);
            this.panel1.TabIndex = 27;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Frequency", true));
            this.frequencyTextBox.Enabled = false;
            this.frequencyTextBox.Location = new System.Drawing.Point(186, 251);
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.Size = new System.Drawing.Size(199, 26);
            this.frequencyTextBox.TabIndex = 39;
            // 
            // dAUBindingSource
            // 
            this.dAUBindingSource.DataMember = "DAU";
            this.dAUBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // comboBox_AreaDAU2
            // 
            this.comboBox_AreaDAU2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Area_ID", true));
            this.comboBox_AreaDAU2.DataSource = this.areaDAUBindingSource;
            this.comboBox_AreaDAU2.DisplayMember = "Description";
            this.comboBox_AreaDAU2.Enabled = false;
            this.comboBox_AreaDAU2.FormattingEnabled = true;
            this.comboBox_AreaDAU2.Location = new System.Drawing.Point(186, 88);
            this.comboBox_AreaDAU2.Name = "comboBox_AreaDAU2";
            this.comboBox_AreaDAU2.Size = new System.Drawing.Size(200, 28);
            this.comboBox_AreaDAU2.TabIndex = 38;
            this.comboBox_AreaDAU2.ValueMember = "Area_ID";
            // 
            // areaDAUBindingSource
            // 
            this.areaDAUBindingSource.DataMember = "AreaDAU";
            this.areaDAUBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // bindingSourceSQL
            // 
            this.bindingSourceSQL.DataSource = this.instrument_databaseDataSet;
            this.bindingSourceSQL.Position = 0;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Communication_ID", true));
            this.comboBoxCOM.DataSource = this.communicationBindingSource;
            this.comboBoxCOM.DisplayMember = "Description";
            this.comboBoxCOM.Enabled = false;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(186, 120);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(200, 28);
            this.comboBoxCOM.TabIndex = 28;
            this.comboBoxCOM.ValueMember = "Communication_ID";
            // 
            // communicationBindingSource
            // 
            this.communicationBindingSource.DataMember = "Communication";
            this.communicationBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // comboBox_AreaDAU
            // 
            this.comboBox_AreaDAU.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dAUBindingSource, "Area_ID", true));
            this.comboBox_AreaDAU.DataSource = this.areaDAUBindingSource;
            this.comboBox_AreaDAU.DisplayMember = "Location";
            this.comboBox_AreaDAU.Enabled = false;
            this.comboBox_AreaDAU.FormattingEnabled = true;
            this.comboBox_AreaDAU.Location = new System.Drawing.Point(186, 55);
            this.comboBox_AreaDAU.Name = "comboBox_AreaDAU";
            this.comboBox_AreaDAU.Size = new System.Drawing.Size(200, 28);
            this.comboBox_AreaDAU.TabIndex = 37;
            this.comboBox_AreaDAU.ValueMember = "Area_ID";
            // 
            // comboBoxDAUfind
            // 
            this.comboBoxDAUfind.DataSource = this.dAUcomboboxBindingSource;
            this.comboBoxDAUfind.DisplayMember = "Description";
            this.comboBoxDAUfind.FormattingEnabled = true;
            this.comboBoxDAUfind.Location = new System.Drawing.Point(186, 23);
            this.comboBoxDAUfind.Name = "comboBoxDAUfind";
            this.comboBoxDAUfind.Size = new System.Drawing.Size(200, 28);
            this.comboBoxDAUfind.TabIndex = 27;
            this.comboBoxDAUfind.ValueMember = "DAU_ID";
            this.comboBoxDAUfind.SelectedIndexChanged += new System.EventHandler(this.comboBoxDAUfind_SelectedIndexChanged);
            // 
            // dAUcomboboxBindingSource
            // 
            this.dAUcomboboxBindingSource.DataMember = "DAU_combobox";
            this.dAUcomboboxBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // config_update_dateDateTimePicker
            // 
            this.config_update_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dAUBindingSource, "Config_update_date", true));
            this.config_update_dateDateTimePicker.Enabled = false;
            this.config_update_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.config_update_dateDateTimePicker.Location = new System.Drawing.Point(186, 218);
            this.config_update_dateDateTimePicker.Name = "config_update_dateDateTimePicker";
            this.config_update_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.config_update_dateDateTimePicker.TabIndex = 24;
            // 
            // cOMPortTextBox
            // 
            this.cOMPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "COMPort", true));
            this.cOMPortTextBox.Enabled = false;
            this.cOMPortTextBox.Location = new System.Drawing.Point(186, 186);
            this.cOMPortTextBox.Name = "cOMPortTextBox";
            this.cOMPortTextBox.Size = new System.Drawing.Size(200, 26);
            this.cOMPortTextBox.TabIndex = 22;
            // 
            // baud_rateTextBox
            // 
            this.baud_rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dAUBindingSource, "Baud_rate", true));
            this.baud_rateTextBox.Enabled = false;
            this.baud_rateTextBox.Location = new System.Drawing.Point(186, 154);
            this.baud_rateTextBox.Name = "baud_rateTextBox";
            this.baud_rateTextBox.Size = new System.Drawing.Size(200, 26);
            this.baud_rateTextBox.TabIndex = 20;
            // 
            // textBoxConnectStatus
            // 
            this.textBoxConnectStatus.BackColor = System.Drawing.Color.Red;
            this.textBoxConnectStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus.Location = new System.Drawing.Point(809, 6);
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
            this.buttonAbout.Location = new System.Drawing.Point(921, 631);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(94, 38);
            this.buttonAbout.TabIndex = 7;
            this.buttonAbout.Text = "&About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // tabPage_Config
            // 
            this.tabPage_Config.AutoScroll = true;
            this.tabPage_Config.Controls.Add(this.label8);
            this.tabPage_Config.Controls.Add(this.buttonRead);
            this.tabPage_Config.Controls.Add(this.buttonWrite);
            this.tabPage_Config.Controls.Add(this.label4);
            this.tabPage_Config.Controls.Add(this.panel4);
            this.tabPage_Config.Controls.Add(this.panel3);
            this.tabPage_Config.Controls.Add(this.textBoxConnectStatus2);
            this.tabPage_Config.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Config.Name = "tabPage_Config";
            this.tabPage_Config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Config.Size = new System.Drawing.Size(1023, 677);
            this.tabPage_Config.TabIndex = 1;
            this.tabPage_Config.Text = "Configuration";
            this.tabPage_Config.UseVisualStyleBackColor = true;
            this.tabPage_Config.Enter += new System.EventHandler(this.tabPage_Config_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(543, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 29);
            this.label8.TabIndex = 73;
            this.label8.Text = "Edit instrument configs";
            // 
            // buttonRead
            // 
            this.buttonRead.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(445, 39);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(106, 38);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "&Read";
            this.toolTip1.SetToolTip(this.buttonRead, "Load the current configuration on the instrument");
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Visible = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite.Location = new System.Drawing.Point(574, 39);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(106, 38);
            this.buttonWrite.TabIndex = 6;
            this.buttonWrite.Text = "&Write";
            this.toolTip1.SetToolTip(this.buttonWrite, "Download the configuration to the instrument");
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Visible = false;
            this.buttonWrite.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Instrument";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_Savetodatabase);
            this.panel4.Controls.Add(this.button_Updatefrominstrument);
            this.panel4.Controls.Add(this.labelTagname);
            this.panel4.Controls.Add(this.buttonOpen);
            this.panel4.Controls.Add(this.buttonSave);
            this.panel4.Controls.Add(this.textBoxAH);
            this.panel4.Controls.Add(this.labelLRW);
            this.panel4.Controls.Add(this.textBoxAL);
            this.panel4.Controls.Add(this.labelURV);
            this.panel4.Controls.Add(this.textBoxURV);
            this.panel4.Controls.Add(this.labelAlarmL);
            this.panel4.Controls.Add(this.textBoxLRV);
            this.panel4.Controls.Add(this.labelAlarmH);
            this.panel4.Controls.Add(this.textBoxTagname);
            this.panel4.Location = new System.Drawing.Point(383, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(574, 322);
            this.panel4.TabIndex = 44;
            // 
            // button_Savetodatabase
            // 
            this.button_Savetodatabase.Location = new System.Drawing.Point(428, 91);
            this.button_Savetodatabase.Name = "button_Savetodatabase";
            this.button_Savetodatabase.Size = new System.Drawing.Size(118, 61);
            this.button_Savetodatabase.TabIndex = 72;
            this.button_Savetodatabase.Text = "&Save to database";
            this.button_Savetodatabase.UseVisualStyleBackColor = true;
            this.button_Savetodatabase.Click += new System.EventHandler(this.button_Savetodatabase_Click);
            // 
            // button_Updatefrominstrument
            // 
            this.button_Updatefrominstrument.Location = new System.Drawing.Point(428, 14);
            this.button_Updatefrominstrument.Name = "button_Updatefrominstrument";
            this.button_Updatefrominstrument.Size = new System.Drawing.Size(118, 64);
            this.button_Updatefrominstrument.TabIndex = 71;
            this.button_Updatefrominstrument.Text = "&Transfer from database";
            this.button_Updatefrominstrument.UseVisualStyleBackColor = true;
            this.button_Updatefrominstrument.Click += new System.EventHandler(this.button_Updatefrominstrument_Click);
            // 
            // labelTagname
            // 
            this.labelTagname.AutoSize = true;
            this.labelTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagname.Location = new System.Drawing.Point(44, 49);
            this.labelTagname.Name = "labelTagname";
            this.labelTagname.Size = new System.Drawing.Size(76, 20);
            this.labelTagname.TabIndex = 0;
            this.labelTagname.Text = "Tagname";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpen.Location = new System.Drawing.Point(428, 167);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(118, 61);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "&Open from file";
            this.toolTip1.SetToolTip(this.buttonOpen, "Load configuration from file");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(428, 242);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 61);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "S&ave to file";
            this.toolTip1.SetToolTip(this.buttonSave, "Save configuration to file");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxAH
            // 
            this.textBoxAH.Location = new System.Drawing.Point(221, 242);
            this.textBoxAH.MaxLength = 4;
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(169, 26);
            this.textBoxAH.TabIndex = 4;
            this.textBoxAH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAH_KeyPress);
            // 
            // labelLRW
            // 
            this.labelLRW.AutoSize = true;
            this.labelLRW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRW.Location = new System.Drawing.Point(44, 95);
            this.labelLRW.Name = "labelLRW";
            this.labelLRW.Size = new System.Drawing.Size(138, 20);
            this.labelLRW.TabIndex = 4;
            this.labelLRW.Text = "Lower range value";
            // 
            // textBoxAL
            // 
            this.textBoxAL.Location = new System.Drawing.Point(221, 195);
            this.textBoxAL.MaxLength = 4;
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(169, 26);
            this.textBoxAL.TabIndex = 3;
            this.textBoxAL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAL_KeyPress);
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(44, 143);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(139, 20);
            this.labelURV.TabIndex = 5;
            this.labelURV.Text = "Upper range value";
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(221, 146);
            this.textBoxURV.MaxLength = 7;
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(169, 26);
            this.textBoxURV.TabIndex = 2;
            this.textBoxURV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURV_KeyPress);
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmL.Location = new System.Drawing.Point(44, 191);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(77, 20);
            this.labelAlarmL.TabIndex = 6;
            this.labelAlarmL.Text = "Alarm low";
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(221, 100);
            this.textBoxLRV.MaxLength = 7;
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(169, 26);
            this.textBoxLRV.TabIndex = 1;
            this.textBoxLRV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLRV_KeyPress);
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmH.Location = new System.Drawing.Point(44, 237);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(84, 20);
            this.labelAlarmH.TabIndex = 7;
            this.labelAlarmH.Text = "Alarm high";
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Enabled = false;
            this.textBoxTagname.Location = new System.Drawing.Point(221, 51);
            this.textBoxTagname.MaxLength = 10;
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.Size = new System.Drawing.Size(169, 26);
            this.textBoxTagname.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(label7);
            this.panel3.Controls.Add(this.comboBox_Maker);
            this.panel3.Controls.Add(lRVLabel);
            this.panel3.Controls.Add(this.lRVTextBox);
            this.panel3.Controls.Add(this.comboBox_Model);
            this.panel3.Controls.Add(this.comboBox_Type);
            this.panel3.Controls.Add(uRVLabel);
            this.panel3.Controls.Add(this.comboBox_AreaInstrument2);
            this.panel3.Controls.Add(this.comboBox_AreaInstrument);
            this.panel3.Controls.Add(this.uRVTextBox);
            this.panel3.Controls.Add(this.comboBoxAD);
            this.panel3.Controls.Add(this.comboBoxIO);
            this.panel3.Controls.Add(descriptionLabel);
            this.panel3.Controls.Add(this.alarm_highTextBox);
            this.panel3.Controls.Add(this.descriptionTextBox);
            this.panel3.Controls.Add(alarm_lowLabel);
            this.panel3.Controls.Add(unitLabel);
            this.panel3.Controls.Add(alarm_highLabel);
            this.panel3.Controls.Add(this.unitTextBox);
            this.panel3.Controls.Add(iO_IDLabel);
            this.panel3.Controls.Add(aD_IDLabel);
            this.panel3.Controls.Add(this.alarm_lowTextBox);
            this.panel3.Controls.Add(area_IDLabel2);
            this.panel3.Controls.Add(type_IDLabel);
            this.panel3.Controls.Add(model_IDLabel);
            this.panel3.Controls.Add(this.comboBoxInstrumentfind);
            this.panel3.Controls.Add(tagnameLabel);
            this.panel3.Location = new System.Drawing.Point(21, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 548);
            this.panel3.TabIndex = 43;
            // 
            // comboBox_Maker
            // 
            this.comboBox_Maker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "Model_ID", true));
            this.comboBox_Maker.DataSource = this.makerBindingSource;
            this.comboBox_Maker.DisplayMember = "Name";
            this.comboBox_Maker.Enabled = false;
            this.comboBox_Maker.FormattingEnabled = true;
            this.comboBox_Maker.Location = new System.Drawing.Point(122, 311);
            this.comboBox_Maker.Name = "comboBox_Maker";
            this.comboBox_Maker.Size = new System.Drawing.Size(187, 28);
            this.comboBox_Maker.TabIndex = 74;
            this.comboBox_Maker.ValueMember = "Maker_ID";
            // 
            // instrumentBindingSource1
            // 
            this.instrumentBindingSource1.DataMember = "Instrument";
            this.instrumentBindingSource1.DataSource = this.instrument_databaseDataSet1;
            // 
            // instrument_databaseDataSet1
            // 
            this.instrument_databaseDataSet1.DataSetName = "Instrument_databaseDataSet";
            this.instrument_databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makerBindingSource
            // 
            this.makerBindingSource.DataMember = "Maker";
            this.makerBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // lRVTextBox
            // 
            this.lRVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource1, "LRV", true));
            this.lRVTextBox.Enabled = false;
            this.lRVTextBox.Location = new System.Drawing.Point(122, 393);
            this.lRVTextBox.Name = "lRVTextBox";
            this.lRVTextBox.Size = new System.Drawing.Size(187, 26);
            this.lRVTextBox.TabIndex = 48;
            // 
            // comboBox_Model
            // 
            this.comboBox_Model.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "Model_ID", true));
            this.comboBox_Model.DataSource = this.modelBindingSource;
            this.comboBox_Model.DisplayMember = "Name";
            this.comboBox_Model.Enabled = false;
            this.comboBox_Model.FormattingEnabled = true;
            this.comboBox_Model.Location = new System.Drawing.Point(122, 344);
            this.comboBox_Model.Name = "comboBox_Model";
            this.comboBox_Model.Size = new System.Drawing.Size(187, 28);
            this.comboBox_Model.TabIndex = 76;
            this.comboBox_Model.ValueMember = "Model_ID";
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "Type_ID", true));
            this.comboBox_Type.DataSource = this.typeBindingSource;
            this.comboBox_Type.DisplayMember = "Name";
            this.comboBox_Type.Enabled = false;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(122, 277);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(187, 28);
            this.comboBox_Type.TabIndex = 75;
            this.comboBox_Type.ValueMember = "Type_ID";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // comboBox_AreaInstrument2
            // 
            this.comboBox_AreaInstrument2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "AD_ID", true));
            this.comboBox_AreaInstrument2.DataSource = this.areaInstrumentBindingSource;
            this.comboBox_AreaInstrument2.DisplayMember = "Description";
            this.comboBox_AreaInstrument2.Enabled = false;
            this.comboBox_AreaInstrument2.FormattingEnabled = true;
            this.comboBox_AreaInstrument2.Location = new System.Drawing.Point(122, 172);
            this.comboBox_AreaInstrument2.Name = "comboBox_AreaInstrument2";
            this.comboBox_AreaInstrument2.Size = new System.Drawing.Size(187, 28);
            this.comboBox_AreaInstrument2.TabIndex = 74;
            this.comboBox_AreaInstrument2.ValueMember = "Area_ID";
            // 
            // areaInstrumentBindingSource
            // 
            this.areaInstrumentBindingSource.DataMember = "Area_Instrument";
            this.areaInstrumentBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // comboBox_AreaInstrument
            // 
            this.comboBox_AreaInstrument.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "Area_ID", true));
            this.comboBox_AreaInstrument.DataSource = this.areaInstrumentBindingSource;
            this.comboBox_AreaInstrument.DisplayMember = "Location";
            this.comboBox_AreaInstrument.Enabled = false;
            this.comboBox_AreaInstrument.FormattingEnabled = true;
            this.comboBox_AreaInstrument.Location = new System.Drawing.Point(122, 137);
            this.comboBox_AreaInstrument.Name = "comboBox_AreaInstrument";
            this.comboBox_AreaInstrument.Size = new System.Drawing.Size(187, 28);
            this.comboBox_AreaInstrument.TabIndex = 73;
            this.comboBox_AreaInstrument.ValueMember = "Area_ID";
            // 
            // uRVTextBox
            // 
            this.uRVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource1, "URV", true));
            this.uRVTextBox.Enabled = false;
            this.uRVTextBox.Location = new System.Drawing.Point(122, 425);
            this.uRVTextBox.Name = "uRVTextBox";
            this.uRVTextBox.Size = new System.Drawing.Size(187, 26);
            this.uRVTextBox.TabIndex = 50;
            // 
            // comboBoxAD
            // 
            this.comboBoxAD.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "AD_ID", true));
            this.comboBoxAD.DataSource = this.aDBindingSource;
            this.comboBoxAD.DisplayMember = "Signal_type";
            this.comboBoxAD.Enabled = false;
            this.comboBoxAD.FormattingEnabled = true;
            this.comboBoxAD.Location = new System.Drawing.Point(122, 242);
            this.comboBoxAD.Name = "comboBoxAD";
            this.comboBoxAD.Size = new System.Drawing.Size(187, 28);
            this.comboBoxAD.TabIndex = 72;
            this.comboBoxAD.ValueMember = "AD_ID";
            // 
            // aDBindingSource
            // 
            this.aDBindingSource.DataMember = "AD";
            this.aDBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // comboBoxIO
            // 
            this.comboBoxIO.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instrumentBindingSource1, "IO_ID", true));
            this.comboBoxIO.DataSource = this.iOBindingSource;
            this.comboBoxIO.DisplayMember = "Signal_type";
            this.comboBoxIO.Enabled = false;
            this.comboBoxIO.FormattingEnabled = true;
            this.comboBoxIO.Location = new System.Drawing.Point(122, 207);
            this.comboBoxIO.Name = "comboBoxIO";
            this.comboBoxIO.Size = new System.Drawing.Size(187, 28);
            this.comboBoxIO.TabIndex = 71;
            this.comboBoxIO.ValueMember = "IO_ID";
            // 
            // iOBindingSource
            // 
            this.iOBindingSource.DataMember = "IO";
            this.iOBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // alarm_highTextBox
            // 
            this.alarm_highTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource1, "Alarm_high", true));
            this.alarm_highTextBox.Enabled = false;
            this.alarm_highTextBox.Location = new System.Drawing.Point(122, 489);
            this.alarm_highTextBox.Name = "alarm_highTextBox";
            this.alarm_highTextBox.Size = new System.Drawing.Size(187, 26);
            this.alarm_highTextBox.TabIndex = 54;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource1, "Description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(122, 71);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(187, 26);
            this.descriptionTextBox.TabIndex = 56;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource1, "Unit", true));
            this.unitTextBox.Enabled = false;
            this.unitTextBox.Location = new System.Drawing.Point(122, 104);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(187, 26);
            this.unitTextBox.TabIndex = 58;
            // 
            // alarm_lowTextBox
            // 
            this.alarm_lowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instrumentBindingSource1, "Alarm_low", true));
            this.alarm_lowTextBox.Enabled = false;
            this.alarm_lowTextBox.Location = new System.Drawing.Point(122, 457);
            this.alarm_lowTextBox.Name = "alarm_lowTextBox";
            this.alarm_lowTextBox.Size = new System.Drawing.Size(187, 26);
            this.alarm_lowTextBox.TabIndex = 52;
            // 
            // comboBoxInstrumentfind
            // 
            this.comboBoxInstrumentfind.DataSource = this.instrumentcomboboxBindingSource;
            this.comboBoxInstrumentfind.DisplayMember = "Tagname";
            this.comboBoxInstrumentfind.FormattingEnabled = true;
            this.comboBoxInstrumentfind.Location = new System.Drawing.Point(122, 36);
            this.comboBoxInstrumentfind.Name = "comboBoxInstrumentfind";
            this.comboBoxInstrumentfind.Size = new System.Drawing.Size(187, 28);
            this.comboBoxInstrumentfind.TabIndex = 43;
            this.comboBoxInstrumentfind.ValueMember = "Tagname";
            this.comboBoxInstrumentfind.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstrumentfind_SelectedIndexChanged);
            // 
            // instrumentcomboboxBindingSource
            // 
            this.instrumentcomboboxBindingSource.DataMember = "Instrument_combobox";
            this.instrumentcomboboxBindingSource.DataSource = this.instrument_databaseDataSet1;
            // 
            // textBoxConnectStatus2
            // 
            this.textBoxConnectStatus2.BackColor = System.Drawing.Color.Red;
            this.textBoxConnectStatus2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus2.Location = new System.Drawing.Point(809, 6);
            this.textBoxConnectStatus2.Name = "textBoxConnectStatus2";
            this.textBoxConnectStatus2.ReadOnly = true;
            this.textBoxConnectStatus2.Size = new System.Drawing.Size(207, 32);
            this.textBoxConnectStatus2.TabIndex = 8;
            this.textBoxConnectStatus2.TabStop = false;
            this.textBoxConnectStatus2.Text = "Not connected";
            this.textBoxConnectStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_Monitoring
            // 
            this.tabPage_Monitoring.AutoScroll = true;
            this.tabPage_Monitoring.Controls.Add(this.label_Analog_log);
            this.tabPage_Monitoring.Controls.Add(this.panel_Digital_Log);
            this.tabPage_Monitoring.Controls.Add(this.tabControl_Observation);
            this.tabPage_Monitoring.Controls.Add(this.label_Observation_AI);
            this.tabPage_Monitoring.Controls.Add(this.buttonSaveGraph);
            this.tabPage_Monitoring.Controls.Add(this.textBoxConnectStatus3);
            this.tabPage_Monitoring.Controls.Add(this.labelStatus);
            this.tabPage_Monitoring.Controls.Add(this.buttonClearData);
            this.tabPage_Monitoring.Controls.Add(this.comboBoxSignal);
            this.tabPage_Monitoring.Controls.Add(this.textBoxStatus);
            this.tabPage_Monitoring.Controls.Add(this.listBoxValues);
            this.tabPage_Monitoring.Controls.Add(this.labelValues);
            this.tabPage_Monitoring.Controls.Add(this.buttonStart);
            this.tabPage_Monitoring.Controls.Add(this.buttonStop);
            this.tabPage_Monitoring.Controls.Add(this.chartValues);
            this.tabPage_Monitoring.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Monitoring.Name = "tabPage_Monitoring";
            this.tabPage_Monitoring.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Monitoring.Size = new System.Drawing.Size(1023, 677);
            this.tabPage_Monitoring.TabIndex = 2;
            this.tabPage_Monitoring.Text = "Monitoring";
            this.tabPage_Monitoring.UseVisualStyleBackColor = true;
            this.tabPage_Monitoring.Enter += new System.EventHandler(this.tabPage_Monitoring_Enter);
            // 
            // panel_Digital_Log
            // 
            this.panel_Digital_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Digital_Log.Controls.Add(this.textBox_Digital_Log);
            this.panel_Digital_Log.Controls.Add(this.label_Digital_Log);
            this.panel_Digital_Log.Location = new System.Drawing.Point(479, 165);
            this.panel_Digital_Log.Name = "panel_Digital_Log";
            this.panel_Digital_Log.Size = new System.Drawing.Size(314, 164);
            this.panel_Digital_Log.TabIndex = 30;
            // 
            // label_Digital_Log
            // 
            this.label_Digital_Log.AutoSize = true;
            this.label_Digital_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Digital_Log.Location = new System.Drawing.Point(60, 17);
            this.label_Digital_Log.Name = "label_Digital_Log";
            this.label_Digital_Log.Size = new System.Drawing.Size(102, 37);
            this.label_Digital_Log.TabIndex = 29;
            this.label_Digital_Log.Text = "label6";
            // 
            // tabControl_Observation
            // 
            this.tabControl_Observation.Controls.Add(this.tabPage_AI);
            this.tabControl_Observation.Controls.Add(this.tabPage_AO);
            this.tabControl_Observation.Controls.Add(this.tabPage_DI);
            this.tabControl_Observation.Controls.Add(this.tabPage_DO);
            this.tabControl_Observation.Location = new System.Drawing.Point(8, 388);
            this.tabControl_Observation.Name = "tabControl_Observation";
            this.tabControl_Observation.SelectedIndex = 0;
            this.tabControl_Observation.Size = new System.Drawing.Size(361, 254);
            this.tabControl_Observation.TabIndex = 27;
            // 
            // tabPage_AI
            // 
            this.tabPage_AI.Controls.Add(observation_IDLabel);
            this.tabPage_AI.Controls.Add(this.textBox_ValueAI);
            this.tabPage_AI.Controls.Add(this.timeDateTimePicker_TagAI);
            this.tabPage_AI.Controls.Add(this.observation_IDTextBox);
            this.tabPage_AI.Controls.Add(timeLabel);
            this.tabPage_AI.Controls.Add(valueLabel);
            this.tabPage_AI.Controls.Add(value_type_IDLabel);
            this.tabPage_AI.Controls.Add(tagnameLabel1);
            this.tabPage_AI.Controls.Add(this.textBox_TagAI);
            this.tabPage_AI.Controls.Add(this.textBox_ValueTypeAI);
            this.tabPage_AI.Location = new System.Drawing.Point(4, 29);
            this.tabPage_AI.Name = "tabPage_AI";
            this.tabPage_AI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AI.Size = new System.Drawing.Size(353, 221);
            this.tabPage_AI.TabIndex = 0;
            this.tabPage_AI.Text = "AI";
            this.tabPage_AI.UseVisualStyleBackColor = true;
            // 
            // textBox_ValueAI
            // 
            this.textBox_ValueAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AIBindingSource, "Value", true));
            this.textBox_ValueAI.Enabled = false;
            this.textBox_ValueAI.Location = new System.Drawing.Point(149, 148);
            this.textBox_ValueAI.Name = "textBox_ValueAI";
            this.textBox_ValueAI.Size = new System.Drawing.Size(140, 26);
            this.textBox_ValueAI.TabIndex = 24;
            // 
            // lOG_AIBindingSource
            // 
            this.lOG_AIBindingSource.DataMember = "LOG_AI";
            this.lOG_AIBindingSource.DataSource = this.instrument_databaseDataSet1;
            // 
            // timeDateTimePicker_TagAI
            // 
            this.timeDateTimePicker_TagAI.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lOG_AIBindingSource, "Time", true));
            this.timeDateTimePicker_TagAI.Enabled = false;
            this.timeDateTimePicker_TagAI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDateTimePicker_TagAI.Location = new System.Drawing.Point(149, 84);
            this.timeDateTimePicker_TagAI.Name = "timeDateTimePicker_TagAI";
            this.timeDateTimePicker_TagAI.Size = new System.Drawing.Size(140, 26);
            this.timeDateTimePicker_TagAI.TabIndex = 20;
            // 
            // observation_IDTextBox
            // 
            this.observation_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AIBindingSource, "Observation_ID", true));
            this.observation_IDTextBox.Enabled = false;
            this.observation_IDTextBox.Location = new System.Drawing.Point(149, 20);
            this.observation_IDTextBox.Name = "observation_IDTextBox";
            this.observation_IDTextBox.Size = new System.Drawing.Size(140, 26);
            this.observation_IDTextBox.TabIndex = 16;
            // 
            // textBox_TagAI
            // 
            this.textBox_TagAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AIBindingSource, "Tagname", true));
            this.textBox_TagAI.Enabled = false;
            this.textBox_TagAI.Location = new System.Drawing.Point(149, 52);
            this.textBox_TagAI.Name = "textBox_TagAI";
            this.textBox_TagAI.Size = new System.Drawing.Size(140, 26);
            this.textBox_TagAI.TabIndex = 18;
            // 
            // textBox_ValueTypeAI
            // 
            this.textBox_ValueTypeAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AIBindingSource, "Value_type_ID", true));
            this.textBox_ValueTypeAI.Enabled = false;
            this.textBox_ValueTypeAI.Location = new System.Drawing.Point(149, 116);
            this.textBox_ValueTypeAI.Name = "textBox_ValueTypeAI";
            this.textBox_ValueTypeAI.Size = new System.Drawing.Size(140, 26);
            this.textBox_ValueTypeAI.TabIndex = 22;
            // 
            // tabPage_AO
            // 
            this.tabPage_AO.AutoScroll = true;
            this.tabPage_AO.Controls.Add(observation_IDLabel1);
            this.tabPage_AO.Controls.Add(this.observation_IDTextBox1);
            this.tabPage_AO.Controls.Add(tagnameLabel2);
            this.tabPage_AO.Controls.Add(this.textBox_TagAO);
            this.tabPage_AO.Controls.Add(timeLabel1);
            this.tabPage_AO.Controls.Add(this.timeDateTimePicker_AO);
            this.tabPage_AO.Controls.Add(value_type_IDLabel1);
            this.tabPage_AO.Controls.Add(this.textBox_VT_AO);
            this.tabPage_AO.Controls.Add(valueLabel1);
            this.tabPage_AO.Controls.Add(this.textBox_Value_AO);
            this.tabPage_AO.Controls.Add(output_timeLabel);
            this.tabPage_AO.Controls.Add(this.timeDateTimePicker_OT_AO);
            this.tabPage_AO.Location = new System.Drawing.Point(4, 29);
            this.tabPage_AO.Name = "tabPage_AO";
            this.tabPage_AO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AO.Size = new System.Drawing.Size(353, 221);
            this.tabPage_AO.TabIndex = 1;
            this.tabPage_AO.Text = "AO";
            this.tabPage_AO.UseVisualStyleBackColor = true;
            // 
            // observation_IDTextBox1
            // 
            this.observation_IDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AOBindingSource, "Observation_ID", true));
            this.observation_IDTextBox1.Enabled = false;
            this.observation_IDTextBox1.Location = new System.Drawing.Point(149, 20);
            this.observation_IDTextBox1.Name = "observation_IDTextBox1";
            this.observation_IDTextBox1.Size = new System.Drawing.Size(140, 26);
            this.observation_IDTextBox1.TabIndex = 1;
            // 
            // lOG_AOBindingSource
            // 
            this.lOG_AOBindingSource.DataMember = "LOG_AO";
            this.lOG_AOBindingSource.DataSource = this.instrument_databaseDataSet1;
            // 
            // textBox_TagAO
            // 
            this.textBox_TagAO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AOBindingSource, "Tagname", true));
            this.textBox_TagAO.Enabled = false;
            this.textBox_TagAO.Location = new System.Drawing.Point(149, 52);
            this.textBox_TagAO.Name = "textBox_TagAO";
            this.textBox_TagAO.Size = new System.Drawing.Size(140, 26);
            this.textBox_TagAO.TabIndex = 3;
            // 
            // timeDateTimePicker_AO
            // 
            this.timeDateTimePicker_AO.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lOG_AOBindingSource, "Time", true));
            this.timeDateTimePicker_AO.Enabled = false;
            this.timeDateTimePicker_AO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDateTimePicker_AO.Location = new System.Drawing.Point(149, 84);
            this.timeDateTimePicker_AO.Name = "timeDateTimePicker_AO";
            this.timeDateTimePicker_AO.Size = new System.Drawing.Size(140, 26);
            this.timeDateTimePicker_AO.TabIndex = 5;
            // 
            // textBox_VT_AO
            // 
            this.textBox_VT_AO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AOBindingSource, "Value_type_ID", true));
            this.textBox_VT_AO.Enabled = false;
            this.textBox_VT_AO.Location = new System.Drawing.Point(149, 116);
            this.textBox_VT_AO.Name = "textBox_VT_AO";
            this.textBox_VT_AO.Size = new System.Drawing.Size(140, 26);
            this.textBox_VT_AO.TabIndex = 7;
            // 
            // textBox_Value_AO
            // 
            this.textBox_Value_AO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_AOBindingSource, "Value", true));
            this.textBox_Value_AO.Enabled = false;
            this.textBox_Value_AO.Location = new System.Drawing.Point(149, 148);
            this.textBox_Value_AO.Name = "textBox_Value_AO";
            this.textBox_Value_AO.Size = new System.Drawing.Size(140, 26);
            this.textBox_Value_AO.TabIndex = 9;
            // 
            // timeDateTimePicker_OT_AO
            // 
            this.timeDateTimePicker_OT_AO.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lOG_AOBindingSource, "Output_time", true));
            this.timeDateTimePicker_OT_AO.Enabled = false;
            this.timeDateTimePicker_OT_AO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDateTimePicker_OT_AO.Location = new System.Drawing.Point(149, 180);
            this.timeDateTimePicker_OT_AO.Name = "timeDateTimePicker_OT_AO";
            this.timeDateTimePicker_OT_AO.Size = new System.Drawing.Size(140, 26);
            this.timeDateTimePicker_OT_AO.TabIndex = 11;
            // 
            // tabPage_DI
            // 
            this.tabPage_DI.AutoScroll = true;
            this.tabPage_DI.Controls.Add(observation_IDLabel2);
            this.tabPage_DI.Controls.Add(this.observation_IDTextBox2);
            this.tabPage_DI.Controls.Add(tagnameLabel3);
            this.tabPage_DI.Controls.Add(this.textBox_TagDI);
            this.tabPage_DI.Controls.Add(timeLabel2);
            this.tabPage_DI.Controls.Add(this.timeDateTimePicker_DI);
            this.tabPage_DI.Controls.Add(valueLabel2);
            this.tabPage_DI.Controls.Add(this.CheckBox_Value_DI);
            this.tabPage_DI.Location = new System.Drawing.Point(4, 29);
            this.tabPage_DI.Name = "tabPage_DI";
            this.tabPage_DI.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DI.Size = new System.Drawing.Size(353, 221);
            this.tabPage_DI.TabIndex = 2;
            this.tabPage_DI.Text = "DI";
            this.tabPage_DI.UseVisualStyleBackColor = true;
            // 
            // observation_IDTextBox2
            // 
            this.observation_IDTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_DIBindingSource, "Observation_ID", true));
            this.observation_IDTextBox2.Enabled = false;
            this.observation_IDTextBox2.Location = new System.Drawing.Point(149, 20);
            this.observation_IDTextBox2.Name = "observation_IDTextBox2";
            this.observation_IDTextBox2.Size = new System.Drawing.Size(140, 26);
            this.observation_IDTextBox2.TabIndex = 1;
            // 
            // lOG_DIBindingSource
            // 
            this.lOG_DIBindingSource.DataMember = "LOG_DI";
            this.lOG_DIBindingSource.DataSource = this.instrument_databaseDataSet1;
            // 
            // textBox_TagDI
            // 
            this.textBox_TagDI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_DIBindingSource, "Tagname", true));
            this.textBox_TagDI.Enabled = false;
            this.textBox_TagDI.Location = new System.Drawing.Point(149, 52);
            this.textBox_TagDI.Name = "textBox_TagDI";
            this.textBox_TagDI.Size = new System.Drawing.Size(140, 26);
            this.textBox_TagDI.TabIndex = 3;
            // 
            // timeDateTimePicker_DI
            // 
            this.timeDateTimePicker_DI.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lOG_DIBindingSource, "Time", true));
            this.timeDateTimePicker_DI.Enabled = false;
            this.timeDateTimePicker_DI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDateTimePicker_DI.Location = new System.Drawing.Point(149, 84);
            this.timeDateTimePicker_DI.Name = "timeDateTimePicker_DI";
            this.timeDateTimePicker_DI.Size = new System.Drawing.Size(140, 26);
            this.timeDateTimePicker_DI.TabIndex = 5;
            // 
            // CheckBox_Value_DI
            // 
            this.CheckBox_Value_DI.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lOG_DIBindingSource, "Value", true));
            this.CheckBox_Value_DI.Enabled = false;
            this.CheckBox_Value_DI.Location = new System.Drawing.Point(149, 116);
            this.CheckBox_Value_DI.Name = "CheckBox_Value_DI";
            this.CheckBox_Value_DI.Size = new System.Drawing.Size(133, 25);
            this.CheckBox_Value_DI.TabIndex = 7;
            this.CheckBox_Value_DI.UseVisualStyleBackColor = true;
            // 
            // tabPage_DO
            // 
            this.tabPage_DO.AutoScroll = true;
            this.tabPage_DO.Controls.Add(observation_IDLabel3);
            this.tabPage_DO.Controls.Add(this.observation_IDTextBox3);
            this.tabPage_DO.Controls.Add(tagnameLabel4);
            this.tabPage_DO.Controls.Add(this.textBox_TagDO);
            this.tabPage_DO.Controls.Add(timeLabel3);
            this.tabPage_DO.Controls.Add(this.timeDateTimePicker_DO);
            this.tabPage_DO.Controls.Add(valueLabel3);
            this.tabPage_DO.Controls.Add(this.CheckBox_Value_DO);
            this.tabPage_DO.Controls.Add(output_timeLabel1);
            this.tabPage_DO.Controls.Add(this.timeDateTimePicker_OutputTime_DO);
            this.tabPage_DO.Location = new System.Drawing.Point(4, 29);
            this.tabPage_DO.Name = "tabPage_DO";
            this.tabPage_DO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DO.Size = new System.Drawing.Size(353, 221);
            this.tabPage_DO.TabIndex = 3;
            this.tabPage_DO.Text = "DO";
            this.tabPage_DO.UseVisualStyleBackColor = true;
            // 
            // observation_IDTextBox3
            // 
            this.observation_IDTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_DOBindingSource, "Observation_ID", true));
            this.observation_IDTextBox3.Enabled = false;
            this.observation_IDTextBox3.Location = new System.Drawing.Point(149, 20);
            this.observation_IDTextBox3.Name = "observation_IDTextBox3";
            this.observation_IDTextBox3.Size = new System.Drawing.Size(140, 26);
            this.observation_IDTextBox3.TabIndex = 1;
            // 
            // lOG_DOBindingSource
            // 
            this.lOG_DOBindingSource.DataMember = "LOG_DO";
            this.lOG_DOBindingSource.DataSource = this.instrument_databaseDataSet1;
            // 
            // textBox_TagDO
            // 
            this.textBox_TagDO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOG_DOBindingSource, "Tagname", true));
            this.textBox_TagDO.Enabled = false;
            this.textBox_TagDO.Location = new System.Drawing.Point(149, 52);
            this.textBox_TagDO.Name = "textBox_TagDO";
            this.textBox_TagDO.Size = new System.Drawing.Size(140, 26);
            this.textBox_TagDO.TabIndex = 3;
            // 
            // timeDateTimePicker_DO
            // 
            this.timeDateTimePicker_DO.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lOG_DOBindingSource, "Time", true));
            this.timeDateTimePicker_DO.Enabled = false;
            this.timeDateTimePicker_DO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDateTimePicker_DO.Location = new System.Drawing.Point(149, 84);
            this.timeDateTimePicker_DO.Name = "timeDateTimePicker_DO";
            this.timeDateTimePicker_DO.Size = new System.Drawing.Size(140, 26);
            this.timeDateTimePicker_DO.TabIndex = 5;
            // 
            // CheckBox_Value_DO
            // 
            this.CheckBox_Value_DO.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.lOG_DOBindingSource, "Value", true));
            this.CheckBox_Value_DO.Enabled = false;
            this.CheckBox_Value_DO.Location = new System.Drawing.Point(149, 116);
            this.CheckBox_Value_DO.Name = "CheckBox_Value_DO";
            this.CheckBox_Value_DO.Size = new System.Drawing.Size(140, 25);
            this.CheckBox_Value_DO.TabIndex = 7;
            this.CheckBox_Value_DO.UseVisualStyleBackColor = true;
            // 
            // timeDateTimePicker_OutputTime_DO
            // 
            this.timeDateTimePicker_OutputTime_DO.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lOG_DOBindingSource, "Output_time", true));
            this.timeDateTimePicker_OutputTime_DO.Enabled = false;
            this.timeDateTimePicker_OutputTime_DO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeDateTimePicker_OutputTime_DO.Location = new System.Drawing.Point(149, 147);
            this.timeDateTimePicker_OutputTime_DO.Name = "timeDateTimePicker_OutputTime_DO";
            this.timeDateTimePicker_OutputTime_DO.Size = new System.Drawing.Size(140, 26);
            this.timeDateTimePicker_OutputTime_DO.TabIndex = 9;
            // 
            // label_Observation_AI
            // 
            this.label_Observation_AI.AutoSize = true;
            this.label_Observation_AI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Observation_AI.Location = new System.Drawing.Point(114, 365);
            this.label_Observation_AI.Name = "label_Observation_AI";
            this.label_Observation_AI.Size = new System.Drawing.Size(105, 20);
            this.label_Observation_AI.TabIndex = 26;
            this.label_Observation_AI.Text = "Observation";
            // 
            // buttonSaveGraph
            // 
            this.buttonSaveGraph.Location = new System.Drawing.Point(907, 634);
            this.buttonSaveGraph.Name = "buttonSaveGraph";
            this.buttonSaveGraph.Size = new System.Drawing.Size(108, 35);
            this.buttonSaveGraph.TabIndex = 14;
            this.buttonSaveGraph.Text = "S&ave graph";
            this.toolTip1.SetToolTip(this.buttonSaveGraph, "Save the graph as image");
            this.buttonSaveGraph.UseVisualStyleBackColor = true;
            this.buttonSaveGraph.Click += new System.EventHandler(this.buttonSaveGraph_Click);
            // 
            // textBoxConnectStatus3
            // 
            this.textBoxConnectStatus3.BackColor = System.Drawing.Color.Red;
            this.textBoxConnectStatus3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConnectStatus3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectStatus3.Location = new System.Drawing.Point(809, 6);
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
            this.labelStatus.Location = new System.Drawing.Point(219, 132);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status";
            // 
            // buttonClearData
            // 
            this.buttonClearData.Location = new System.Drawing.Point(206, 33);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(75, 35);
            this.buttonClearData.TabIndex = 3;
            this.buttonClearData.Text = "&Clear";
            this.toolTip1.SetToolTip(this.buttonClearData, "Clear data");
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Items.AddRange(new object[] {
            "Raw",
            "Scaled"});
            this.comboBoxSignal.Location = new System.Drawing.Point(497, 13);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(172, 28);
            this.comboBoxSignal.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxSignal, "Choose sensor signal type");
            this.comboBoxSignal.Visible = false;
            this.comboBoxSignal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSignal_KeyPress);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(201, 165);
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
            this.listBoxValues.Location = new System.Drawing.Point(53, 165);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.Size = new System.Drawing.Size(102, 184);
            this.listBoxValues.TabIndex = 6;
            this.listBoxValues.TabStop = false;
            // 
            // labelValues
            // 
            this.labelValues.AutoSize = true;
            this.labelValues.Location = new System.Drawing.Point(71, 132);
            this.labelValues.Name = "labelValues";
            this.labelValues.Size = new System.Drawing.Size(58, 20);
            this.labelValues.TabIndex = 5;
            this.labelValues.Text = "Values";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(20, 33);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(76, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "&Start";
            this.toolTip1.SetToolTip(this.buttonStart, "Start monitoring");
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(114, 33);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(76, 35);
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
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartValues.Series.Add(series1);
            this.chartValues.Size = new System.Drawing.Size(695, 628);
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
            // tabPage_LogData
            // 
            this.tabPage_LogData.AutoScroll = true;
            this.tabPage_LogData.Controls.Add(this.label_TagnameLog);
            this.tabPage_LogData.Controls.Add(this.label_LOG);
            this.tabPage_LogData.Controls.Add(this.dataGridView_LOG);
            this.tabPage_LogData.Location = new System.Drawing.Point(4, 29);
            this.tabPage_LogData.Name = "tabPage_LogData";
            this.tabPage_LogData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LogData.Size = new System.Drawing.Size(1023, 677);
            this.tabPage_LogData.TabIndex = 3;
            this.tabPage_LogData.Text = "Log Data";
            this.tabPage_LogData.UseVisualStyleBackColor = true;
            this.tabPage_LogData.Enter += new System.EventHandler(this.tabPage_LogData_Enter);
            // 
            // label_TagnameLog
            // 
            this.label_TagnameLog.AutoSize = true;
            this.label_TagnameLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TagnameLog.Location = new System.Drawing.Point(399, 10);
            this.label_TagnameLog.Name = "label_TagnameLog";
            this.label_TagnameLog.Size = new System.Drawing.Size(99, 32);
            this.label_TagnameLog.TabIndex = 2;
            this.label_TagnameLog.Text = "label6";
            // 
            // label_LOG
            // 
            this.label_LOG.AutoSize = true;
            this.label_LOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LOG.Location = new System.Drawing.Point(19, 10);
            this.label_LOG.Name = "label_LOG";
            this.label_LOG.Size = new System.Drawing.Size(0, 32);
            this.label_LOG.TabIndex = 1;
            // 
            // dataGridView_LOG
            // 
            this.dataGridView_LOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LOG.Location = new System.Drawing.Point(8, 55);
            this.dataGridView_LOG.Name = "dataGridView_LOG";
            this.dataGridView_LOG.RowHeadersWidth = 62;
            this.dataGridView_LOG.RowTemplate.Height = 28;
            this.dataGridView_LOG.Size = new System.Drawing.Size(986, 614);
            this.dataGridView_LOG.TabIndex = 0;
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
            // saveFileDialogGraph
            // 
            this.saveFileDialogGraph.FileName = "Graph";
            this.saveFileDialogGraph.Filter = "PNG Image|*.png|JPeg Image|*.jpg";
            // 
            // lOGAOBindingSource
            // 
            this.lOGAOBindingSource.DataMember = "LOG_AO";
            this.lOGAOBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // lOGDIBindingSource
            // 
            this.lOGDIBindingSource.DataMember = "LOG_DI";
            this.lOGDIBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // lOGDOBindingSource
            // 
            this.lOGDOBindingSource.DataMember = "LOG_DO";
            this.lOGDOBindingSource.DataSource = this.bindingSourceSQL;
            // 
            // timer_ChartSimulation
            // 
            this.timer_ChartSimulation.Interval = 1000;
            this.timer_ChartSimulation.Tick += new System.EventHandler(this.timer_ChartSimulation_Tick);
            // 
            // timer_StatusSimulation
            // 
            this.timer_StatusSimulation.Interval = 10;
            // 
            // instrumentBindingSource
            // 
            this.instrumentBindingSource.DataMember = "Instrument";
            this.instrumentBindingSource.DataSource = this.instrument_databaseDataSet;
            // 
            // dAUTableAdapter
            // 
            this.dAUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADTableAdapter = null;
            this.tableAdapterManager.Area_InstrumentTableAdapter = null;
            this.tableAdapterManager.AreaDAUTableAdapter = null;
            this.tableAdapterManager.AreaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommunicationTableAdapter = null;
            this.tableAdapterManager.DAU_comboboxTableAdapter = null;
            this.tableAdapterManager.DAUTableAdapter = this.dAUTableAdapter;
            this.tableAdapterManager.Instrument_comboboxTableAdapter = null;
            this.tableAdapterManager.InstrumentTableAdapter = null;
            this.tableAdapterManager.IOTableAdapter = null;
            this.tableAdapterManager.LOG_AITableAdapter = null;
            this.tableAdapterManager.LOG_AOTableAdapter = null;
            this.tableAdapterManager.LOG_DITableAdapter = null;
            this.tableAdapterManager.LOG_DOTableAdapter = null;
            this.tableAdapterManager.MakerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.RDC_comboboxTableAdapter = null;
            this.tableAdapterManager.RDCTableAdapter = this.rDCTableAdapter;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SoftSensConf.Instrument_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Value_typeTableAdapter = null;
            // 
            // rDCTableAdapter
            // 
            this.rDCTableAdapter.ClearBeforeFill = true;
            // 
            // dAU_comboboxTableAdapter
            // 
            this.dAU_comboboxTableAdapter.ClearBeforeFill = true;
            // 
            // rDC_comboboxTableAdapter
            // 
            this.rDC_comboboxTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // communicationTableAdapter
            // 
            this.communicationTableAdapter.ClearBeforeFill = true;
            // 
            // areaDAUTableAdapter
            // 
            this.areaDAUTableAdapter.ClearBeforeFill = true;
            // 
            // instrumentTableAdapter
            // 
            this.instrumentTableAdapter.ClearBeforeFill = true;
            // 
            // instrument_comboboxTableAdapter
            // 
            this.instrument_comboboxTableAdapter.ClearBeforeFill = true;
            // 
            // iOTableAdapter
            // 
            this.iOTableAdapter.ClearBeforeFill = true;
            // 
            // aDTableAdapter
            // 
            this.aDTableAdapter.ClearBeforeFill = true;
            // 
            // area_InstrumentTableAdapter
            // 
            this.area_InstrumentTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // lOG_AITableAdapter
            // 
            this.lOG_AITableAdapter.ClearBeforeFill = true;
            // 
            // lOG_AOTableAdapter
            // 
            this.lOG_AOTableAdapter.ClearBeforeFill = true;
            // 
            // lOG_DITableAdapter
            // 
            this.lOG_DITableAdapter.ClearBeforeFill = true;
            // 
            // lOG_DOTableAdapter
            // 
            this.lOG_DOTableAdapter.ClearBeforeFill = true;
            // 
            // makerTableAdapter
            // 
            this.makerTableAdapter.ClearBeforeFill = true;
            // 
            // dAUBindingSource1
            // 
            this.dAUBindingSource1.DataMember = "DAU";
            this.dAUBindingSource1.DataSource = this.instrument_databaseDataSet1;
            // 
            // label_Analog_log
            // 
            this.label_Analog_log.AutoSize = true;
            this.label_Analog_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Analog_log.Location = new System.Drawing.Point(542, 89);
            this.label_Analog_log.Name = "label_Analog_log";
            this.label_Analog_log.Size = new System.Drawing.Size(102, 37);
            this.label_Analog_log.TabIndex = 32;
            this.label_Analog_log.Text = "label6";
            // 
            // textBox_Digital_Log
            // 
            this.textBox_Digital_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Digital_Log.Location = new System.Drawing.Point(102, 73);
            this.textBox_Digital_Log.Name = "textBox_Digital_Log";
            this.textBox_Digital_Log.Size = new System.Drawing.Size(100, 39);
            this.textBox_Digital_Log.TabIndex = 30;
            this.textBox_Digital_Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 710);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Connection.ResumeLayout(false);
            this.tabPage_Connection.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rDCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDCcomboboxBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaDAUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.communicationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUcomboboxBindingSource)).EndInit();
            this.tabPage_Config.ResumeLayout(false);
            this.tabPage_Config.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrument_databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaInstrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentcomboboxBindingSource)).EndInit();
            this.tabPage_Monitoring.ResumeLayout(false);
            this.tabPage_Monitoring.PerformLayout();
            this.panel_Digital_Log.ResumeLayout(false);
            this.panel_Digital_Log.PerformLayout();
            this.tabControl_Observation.ResumeLayout(false);
            this.tabPage_AI.ResumeLayout(false);
            this.tabPage_AI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_AIBindingSource)).EndInit();
            this.tabPage_AO.ResumeLayout(false);
            this.tabPage_AO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_AOBindingSource)).EndInit();
            this.tabPage_DI.ResumeLayout(false);
            this.tabPage_DI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_DIBindingSource)).EndInit();
            this.tabPage_DO.ResumeLayout(false);
            this.tabPage_DO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOG_DOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValues)).EndInit();
            this.tabPage_LogData.ResumeLayout(false);
            this.tabPage_LogData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGDIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Connection;
        private System.Windows.Forms.TabPage tabPage_Config;
        private System.Windows.Forms.TabPage tabPage_Monitoring;
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
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Timer timerConnection;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxConnectStatus3;
        private System.Windows.Forms.TextBox textBoxConnectStatus;
        private System.Windows.Forms.Button buttonSaveGraph;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGraph;
        private System.Windows.Forms.BindingSource bindingSourceSQL;
        private Instrument_databaseDataSet instrument_databaseDataSet;
        private System.Windows.Forms.BindingSource dAUBindingSource;
        private Instrument_databaseDataSetTableAdapters.DAUTableAdapter dAUTableAdapter;
        private Instrument_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox baud_rateTextBox;
        private System.Windows.Forms.TextBox cOMPortTextBox;
        private System.Windows.Forms.DateTimePicker config_update_dateDateTimePicker;
        private System.Windows.Forms.Panel panel1;
        private Instrument_databaseDataSetTableAdapters.RDCTableAdapter rDCTableAdapter;
        private System.Windows.Forms.BindingSource rDCBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox iPaddressTextBox;
        private System.Windows.Forms.ComboBox comboBoxRDCfind;
        private System.Windows.Forms.ComboBox comboBoxDAUfind;
        private System.Windows.Forms.BindingSource dAUcomboboxBindingSource;
        private Instrument_databaseDataSetTableAdapters.DAU_comboboxTableAdapter dAU_comboboxTableAdapter;
        private System.Windows.Forms.BindingSource rDCcomboboxBindingSource;
        private Instrument_databaseDataSetTableAdapters.RDC_comboboxTableAdapter rDC_comboboxTableAdapter;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private Instrument_databaseDataSetTableAdapters.AreaTableAdapter areaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_AreaRDC;
        private System.Windows.Forms.ComboBox comboBox_AreaRDC2;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.BindingSource communicationBindingSource;
        private Instrument_databaseDataSetTableAdapters.CommunicationTableAdapter communicationTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_AreaDAU2;
        private System.Windows.Forms.ComboBox comboBox_AreaDAU;
        private System.Windows.Forms.BindingSource areaDAUBindingSource;
        private Instrument_databaseDataSetTableAdapters.AreaDAUTableAdapter areaDAUTableAdapter;
        private System.Windows.Forms.BindingSource instrumentBindingSource;
        private Instrument_databaseDataSetTableAdapters.InstrumentTableAdapter instrumentTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxInstrumentfind;
        private Instrument_databaseDataSet instrument_databaseDataSet1;
        private System.Windows.Forms.BindingSource instrumentcomboboxBindingSource;
        private Instrument_databaseDataSetTableAdapters.Instrument_comboboxTableAdapter instrument_comboboxTableAdapter;
        private System.Windows.Forms.BindingSource instrumentBindingSource1;
        private System.Windows.Forms.TextBox lRVTextBox;
        private System.Windows.Forms.TextBox uRVTextBox;
        private System.Windows.Forms.TextBox alarm_lowTextBox;
        private System.Windows.Forms.TextBox alarm_highTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxIO;
        private System.Windows.Forms.BindingSource iOBindingSource;
        private Instrument_databaseDataSetTableAdapters.IOTableAdapter iOTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxAD;
        private System.Windows.Forms.BindingSource aDBindingSource;
        private Instrument_databaseDataSetTableAdapters.ADTableAdapter aDTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_AreaInstrument2;
        private System.Windows.Forms.ComboBox comboBox_AreaInstrument;
        private System.Windows.Forms.BindingSource areaInstrumentBindingSource;
        private Instrument_databaseDataSetTableAdapters.Area_InstrumentTableAdapter area_InstrumentTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private Instrument_databaseDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Model;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private Instrument_databaseDataSetTableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.Button button_Updatefrominstrument;
        private System.Windows.Forms.Button button_Savetodatabase;
        private System.Windows.Forms.Button button_TransfConnection;
        private System.Windows.Forms.TextBox textBox_DAUConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage_LogData;
        private System.Windows.Forms.BindingSource lOG_AIBindingSource;
        private Instrument_databaseDataSetTableAdapters.LOG_AITableAdapter lOG_AITableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_LOG;
        private System.Windows.Forms.BindingSource lOGAOBindingSource;
        private Instrument_databaseDataSetTableAdapters.LOG_AOTableAdapter lOG_AOTableAdapter;
        private System.Windows.Forms.Label label_LOG;
        private System.Windows.Forms.BindingSource lOGDIBindingSource;
        private Instrument_databaseDataSetTableAdapters.LOG_DITableAdapter lOG_DITableAdapter;
        private System.Windows.Forms.BindingSource lOGDOBindingSource;
        private Instrument_databaseDataSetTableAdapters.LOG_DOTableAdapter lOG_DOTableAdapter;
        private System.Windows.Forms.Timer timer_ChartSimulation;
        private System.Windows.Forms.Timer timer_StatusSimulation;
        private System.Windows.Forms.TextBox observation_IDTextBox;
        private System.Windows.Forms.TextBox textBox_TagAI;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker_TagAI;
        private System.Windows.Forms.TextBox textBox_ValueAI;
        private System.Windows.Forms.Label label_TagnameLog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ValueTypeAI;
        private System.Windows.Forms.Label label_Observation_AI;
        private System.Windows.Forms.TabControl tabControl_Observation;
        private System.Windows.Forms.TabPage tabPage_AI;
        private System.Windows.Forms.TabPage tabPage_AO;
        private System.Windows.Forms.TextBox observation_IDTextBox1;
        private System.Windows.Forms.BindingSource lOG_AOBindingSource;
        private System.Windows.Forms.TextBox textBox_TagAO;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker_AO;
        private System.Windows.Forms.TextBox textBox_VT_AO;
        private System.Windows.Forms.TextBox textBox_Value_AO;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker_OT_AO;
        private System.Windows.Forms.BindingSource lOG_DIBindingSource;
        private System.Windows.Forms.BindingSource lOG_DOBindingSource;
        private System.Windows.Forms.ComboBox comboBox_Maker;
        private System.Windows.Forms.BindingSource makerBindingSource;
        private Instrument_databaseDataSetTableAdapters.MakerTableAdapter makerTableAdapter;
        private System.Windows.Forms.TabPage tabPage_DI;
        private System.Windows.Forms.TextBox observation_IDTextBox2;
        private System.Windows.Forms.TextBox textBox_TagDI;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker_DI;
        private System.Windows.Forms.CheckBox CheckBox_Value_DI;
        private System.Windows.Forms.TabPage tabPage_DO;
        private System.Windows.Forms.TextBox observation_IDTextBox3;
        private System.Windows.Forms.TextBox textBox_TagDO;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker_DO;
        private System.Windows.Forms.CheckBox CheckBox_Value_DO;
        private System.Windows.Forms.DateTimePicker timeDateTimePicker_OutputTime_DO;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.BindingSource dAUBindingSource1;
        private System.Windows.Forms.Label label_Digital_Log;
        private System.Windows.Forms.Panel panel_Digital_Log;
        private System.Windows.Forms.Label label_Analog_log;
        private System.Windows.Forms.TextBox textBox_Digital_Log;
    }
}

