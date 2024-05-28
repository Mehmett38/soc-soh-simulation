namespace _001_cellSimulatorV1._1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxSerialCom = new System.Windows.Forms.GroupBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortName = new System.Windows.Forms.ComboBox();
            this.serialPortTI = new System.IO.Ports.SerialPort(this.components);
            this.timerUpdateUart = new System.Windows.Forms.Timer(this.components);
            this.panelFormControl = new System.Windows.Forms.Panel();
            this.pictureBoxMinimizeForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxResizeForm = new System.Windows.Forms.PictureBox();
            this.pictureBoxCloseForm = new System.Windows.Forms.PictureBox();
            this.groupBoxBattery = new System.Windows.Forms.GroupBox();
            this.labelVolt = new System.Windows.Forms.Label();
            this.labelSOC = new System.Windows.Forms.Label();
            this.chartVoltCap = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonCharge = new System.Windows.Forms.RadioButton();
            this.radioButtonDischarge = new System.Windows.Forms.RadioButton();
            this.progressBarSOC = new System.Windows.Forms.ProgressBar();
            this.pictureBoxProgVoltage = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.pictureBoxBattery = new System.Windows.Forms.PictureBox();
            this.pictureBoxProgFront = new System.Windows.Forms.PictureBox();
            this.groupBoxSerialCom.SuspendLayout();
            this.panelFormControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).BeginInit();
            this.groupBoxBattery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgFront)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSerialCom
            // 
            this.groupBoxSerialCom.Controls.Add(this.buttonDisconnect);
            this.groupBoxSerialCom.Controls.Add(this.buttonConnect);
            this.groupBoxSerialCom.Controls.Add(this.label5);
            this.groupBoxSerialCom.Controls.Add(this.label4);
            this.groupBoxSerialCom.Controls.Add(this.label3);
            this.groupBoxSerialCom.Controls.Add(this.label2);
            this.groupBoxSerialCom.Controls.Add(this.label1);
            this.groupBoxSerialCom.Controls.Add(this.comboBoxStopBit);
            this.groupBoxSerialCom.Controls.Add(this.comboBoxParity);
            this.groupBoxSerialCom.Controls.Add(this.comboBoxDataBits);
            this.groupBoxSerialCom.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerialCom.Controls.Add(this.comboBoxPortName);
            this.groupBoxSerialCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSerialCom.Location = new System.Drawing.Point(12, 39);
            this.groupBoxSerialCom.Name = "groupBoxSerialCom";
            this.groupBoxSerialCom.Size = new System.Drawing.Size(179, 488);
            this.groupBoxSerialCom.TabIndex = 1;
            this.groupBoxSerialCom.TabStop = false;
            this.groupBoxSerialCom.Text = "Serial Communication";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDisconnect.Location = new System.Drawing.Point(29, 387);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(118, 29);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.serialPortButtonClick);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonConnect.Location = new System.Drawing.Point(29, 347);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(118, 29);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.serialPortButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stop Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Name";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(9, 298);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(157, 24);
            this.comboBoxStopBit.TabIndex = 4;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(9, 238);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(157, 24);
            this.comboBoxParity.TabIndex = 3;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(9, 181);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(157, 24);
            this.comboBoxDataBits.TabIndex = 2;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "110",
            "300",
            "600\t",
            "1200\t",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "230400",
            ""});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(9, 124);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(157, 24);
            this.comboBoxBaudRate.TabIndex = 1;
            // 
            // comboBoxPortName
            // 
            this.comboBoxPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPortName.FormattingEnabled = true;
            this.comboBoxPortName.Location = new System.Drawing.Point(9, 71);
            this.comboBoxPortName.Name = "comboBoxPortName";
            this.comboBoxPortName.Size = new System.Drawing.Size(157, 24);
            this.comboBoxPortName.TabIndex = 0;
            // 
            // timerUpdateUart
            // 
            this.timerUpdateUart.Tick += new System.EventHandler(this.timerUpdateUart_Tick);
            // 
            // panelFormControl
            // 
            this.panelFormControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelFormControl.Controls.Add(this.pictureBoxMinimizeForm);
            this.panelFormControl.Controls.Add(this.pictureBoxResizeForm);
            this.panelFormControl.Controls.Add(this.pictureBoxCloseForm);
            this.panelFormControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormControl.Location = new System.Drawing.Point(0, 0);
            this.panelFormControl.Name = "panelFormControl";
            this.panelFormControl.Size = new System.Drawing.Size(769, 33);
            this.panelFormControl.TabIndex = 2;
            this.panelFormControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelFormControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFormControl_MouseMove);
            // 
            // pictureBoxMinimizeForm
            // 
            this.pictureBoxMinimizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimizeForm.Image = global::_001_cellSimulatorV1._1.Properties.Resources.minimizeIcon;
            this.pictureBoxMinimizeForm.Location = new System.Drawing.Point(672, 3);
            this.pictureBoxMinimizeForm.Name = "pictureBoxMinimizeForm";
            this.pictureBoxMinimizeForm.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxMinimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimizeForm.TabIndex = 3;
            this.pictureBoxMinimizeForm.TabStop = false;
            this.pictureBoxMinimizeForm.Click += new System.EventHandler(this.formSizeIconClick);
            this.pictureBoxMinimizeForm.MouseLeave += new System.EventHandler(this.mauseLeaveEvent);
            this.pictureBoxMinimizeForm.MouseHover += new System.EventHandler(this.mauseHoverEvent);
            // 
            // pictureBoxResizeForm
            // 
            this.pictureBoxResizeForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxResizeForm.Image = global::_001_cellSimulatorV1._1.Properties.Resources.minizeIcon;
            this.pictureBoxResizeForm.Location = new System.Drawing.Point(705, 3);
            this.pictureBoxResizeForm.Name = "pictureBoxResizeForm";
            this.pictureBoxResizeForm.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxResizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxResizeForm.TabIndex = 3;
            this.pictureBoxResizeForm.TabStop = false;
            this.pictureBoxResizeForm.Click += new System.EventHandler(this.formSizeIconClick);
            this.pictureBoxResizeForm.MouseLeave += new System.EventHandler(this.mauseLeaveEvent);
            this.pictureBoxResizeForm.MouseHover += new System.EventHandler(this.mauseHoverEvent);
            // 
            // pictureBoxCloseForm
            // 
            this.pictureBoxCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCloseForm.Image = global::_001_cellSimulatorV1._1.Properties.Resources.closeIcon;
            this.pictureBoxCloseForm.Location = new System.Drawing.Point(738, 3);
            this.pictureBoxCloseForm.Name = "pictureBoxCloseForm";
            this.pictureBoxCloseForm.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseForm.TabIndex = 3;
            this.pictureBoxCloseForm.TabStop = false;
            this.pictureBoxCloseForm.Click += new System.EventHandler(this.formSizeIconClick);
            this.pictureBoxCloseForm.MouseLeave += new System.EventHandler(this.mauseLeaveEvent);
            this.pictureBoxCloseForm.MouseHover += new System.EventHandler(this.mauseHoverEvent);
            // 
            // groupBoxBattery
            // 
            this.groupBoxBattery.Controls.Add(this.labelVolt);
            this.groupBoxBattery.Controls.Add(this.labelSOC);
            this.groupBoxBattery.Controls.Add(this.chartVoltCap);
            this.groupBoxBattery.Controls.Add(this.radioButtonCharge);
            this.groupBoxBattery.Controls.Add(this.radioButtonDischarge);
            this.groupBoxBattery.Controls.Add(this.progressBarSOC);
            this.groupBoxBattery.Controls.Add(this.pictureBoxProgVoltage);
            this.groupBoxBattery.Controls.Add(this.pictureBoxStop);
            this.groupBoxBattery.Controls.Add(this.pictureBoxStart);
            this.groupBoxBattery.Controls.Add(this.pictureBoxBattery);
            this.groupBoxBattery.Controls.Add(this.pictureBoxProgFront);
            this.groupBoxBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxBattery.Location = new System.Drawing.Point(197, 39);
            this.groupBoxBattery.Name = "groupBoxBattery";
            this.groupBoxBattery.Size = new System.Drawing.Size(560, 488);
            this.groupBoxBattery.TabIndex = 3;
            this.groupBoxBattery.TabStop = false;
            this.groupBoxBattery.Text = "Cell Simulation";
            // 
            // labelVolt
            // 
            this.labelVolt.AutoSize = true;
            this.labelVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVolt.Location = new System.Drawing.Point(348, 19);
            this.labelVolt.Name = "labelVolt";
            this.labelVolt.Size = new System.Drawing.Size(29, 16);
            this.labelVolt.TabIndex = 25;
            this.labelVolt.Text = "V = ";
            // 
            // labelSOC
            // 
            this.labelSOC.AutoSize = true;
            this.labelSOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSOC.Location = new System.Drawing.Point(227, 207);
            this.labelSOC.Name = "labelSOC";
            this.labelSOC.Size = new System.Drawing.Size(51, 16);
            this.labelSOC.TabIndex = 24;
            this.labelSOC.Text = "SOC : 0";
            // 
            // chartVoltCap
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVoltCap.ChartAreas.Add(chartArea2);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend2.Name = "Legend1";
            this.chartVoltCap.Legends.Add(legend2);
            this.chartVoltCap.Location = new System.Drawing.Point(19, 277);
            this.chartVoltCap.Name = "chartVoltCap";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartVoltCap.Series.Add(series2);
            this.chartVoltCap.Size = new System.Drawing.Size(524, 205);
            this.chartVoltCap.TabIndex = 23;
            this.chartVoltCap.Text = "chart1";
            // 
            // radioButtonCharge
            // 
            this.radioButtonCharge.AutoSize = true;
            this.radioButtonCharge.Checked = true;
            this.radioButtonCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonCharge.Location = new System.Drawing.Point(380, 214);
            this.radioButtonCharge.Name = "radioButtonCharge";
            this.radioButtonCharge.Size = new System.Drawing.Size(75, 20);
            this.radioButtonCharge.TabIndex = 21;
            this.radioButtonCharge.TabStop = true;
            this.radioButtonCharge.Text = "Charge";
            this.radioButtonCharge.UseVisualStyleBackColor = true;
            // 
            // radioButtonDischarge
            // 
            this.radioButtonDischarge.AutoSize = true;
            this.radioButtonDischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonDischarge.Location = new System.Drawing.Point(380, 236);
            this.radioButtonDischarge.Name = "radioButtonDischarge";
            this.radioButtonDischarge.Size = new System.Drawing.Size(96, 20);
            this.radioButtonDischarge.TabIndex = 22;
            this.radioButtonDischarge.Text = "Discharge";
            this.radioButtonDischarge.UseVisualStyleBackColor = true;
            // 
            // progressBarSOC
            // 
            this.progressBarSOC.Location = new System.Drawing.Point(191, 203);
            this.progressBarSOC.Name = "progressBarSOC";
            this.progressBarSOC.Size = new System.Drawing.Size(160, 23);
            this.progressBarSOC.TabIndex = 20;
            // 
            // pictureBoxProgVoltage
            // 
            this.pictureBoxProgVoltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pictureBoxProgVoltage.Location = new System.Drawing.Point(367, 38);
            this.pictureBoxProgVoltage.Name = "pictureBoxProgVoltage";
            this.pictureBoxProgVoltage.Size = new System.Drawing.Size(23, 150);
            this.pictureBoxProgVoltage.TabIndex = 19;
            this.pictureBoxProgVoltage.TabStop = false;
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Image = global::_001_cellSimulatorV1._1.Properties.Resources.Stop_red_icon;
            this.pictureBoxStop.Location = new System.Drawing.Point(233, 232);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(30, 29);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop.TabIndex = 17;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxTaskClick);
            this.pictureBoxStop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cellSimulationMauseMove);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = global::_001_cellSimulatorV1._1.Properties.Resources.Start_icon;
            this.pictureBoxStart.Location = new System.Drawing.Point(287, 232);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(30, 29);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStart.TabIndex = 18;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxTaskClick);
            this.pictureBoxStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cellSimulationMauseMove);
            // 
            // pictureBoxBattery
            // 
            this.pictureBoxBattery.Image = global::_001_cellSimulatorV1._1.Properties.Resources.moli;
            this.pictureBoxBattery.Location = new System.Drawing.Point(179, 29);
            this.pictureBoxBattery.Name = "pictureBoxBattery";
            this.pictureBoxBattery.Size = new System.Drawing.Size(182, 166);
            this.pictureBoxBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBattery.TabIndex = 10;
            this.pictureBoxBattery.TabStop = false;
            this.pictureBoxBattery.Click += new System.EventHandler(this.pictureBoxBattery_Click);
            this.pictureBoxBattery.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cellSimulationMauseMove);
            // 
            // pictureBoxProgFront
            // 
            this.pictureBoxProgFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBoxProgFront.Location = new System.Drawing.Point(367, 38);
            this.pictureBoxProgFront.Name = "pictureBoxProgFront";
            this.pictureBoxProgFront.Size = new System.Drawing.Size(23, 150);
            this.pictureBoxProgFront.TabIndex = 26;
            this.pictureBoxProgFront.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 539);
            this.Controls.Add(this.groupBoxBattery);
            this.Controls.Add(this.panelFormControl);
            this.Controls.Add(this.groupBoxSerialCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxSerialCom.ResumeLayout(false);
            this.groupBoxSerialCom.PerformLayout();
            this.panelFormControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseForm)).EndInit();
            this.groupBoxBattery.ResumeLayout(false);
            this.groupBoxBattery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVoltCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProgFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSerialCom;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxPortName;
        private System.IO.Ports.SerialPort serialPortTI;
        private System.Windows.Forms.Timer timerUpdateUart;
        private System.Windows.Forms.Panel panelFormControl;
        private System.Windows.Forms.PictureBox pictureBoxMinimizeForm;
        private System.Windows.Forms.PictureBox pictureBoxResizeForm;
        private System.Windows.Forms.PictureBox pictureBoxCloseForm;
        private System.Windows.Forms.GroupBox groupBoxBattery;
        private System.Windows.Forms.PictureBox pictureBoxBattery;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.ProgressBar progressBarSOC;
        private System.Windows.Forms.PictureBox pictureBoxProgVoltage;
        private System.Windows.Forms.RadioButton radioButtonCharge;
        private System.Windows.Forms.RadioButton radioButtonDischarge;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVoltCap;
        private System.Windows.Forms.Label labelSOC;
        private System.Windows.Forms.Label labelVolt;
        private System.Windows.Forms.PictureBox pictureBoxProgFront;
    }
}

