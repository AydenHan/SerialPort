namespace SerialPort
{
    partial class SerialPort
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerialPort));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbParityBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDataBit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbDataRX = new System.Windows.Forms.TextBox();
            this.gbDataRX = new System.Windows.Forms.GroupBox();
            this.ckbHex = new System.Windows.Forms.CheckBox();
            this.btnClearDataRX = new System.Windows.Forms.Button();
            this.btnSendData = new System.Windows.Forms.Button();
            this.btnClearDataTX = new System.Windows.Forms.Button();
            this.ckbHexSend = new System.Windows.Forms.CheckBox();
            this.ckbAddrn = new System.Windows.Forms.CheckBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslWebLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataTXNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDataRXNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.ckbSendTimer = new System.Windows.Forms.CheckBox();
            this.tbSendTimer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.tcDataTX = new System.Windows.Forms.TabControl();
            this.tpSingleSend = new System.Windows.Forms.TabPage();
            this.tbDataTX = new System.Windows.Forms.TextBox();
            this.tpMultiSend = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.gbDataRX.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tcDataTX.SuspendLayout();
            this.tpSingleSend.SuspendLayout();
            this.tpMultiSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbStopBit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbParityBit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDataBit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(1033, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 393);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.AutoSize = true;
            this.btnOpenPort.Location = new System.Drawing.Point(138, 318);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(141, 53);
            this.btnOpenPort.TabIndex = 11;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.TextChanged += new System.EventHandler(this.btnOpenPort_TextChanged);
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "操    作";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "1200"});
            this.cbBaudRate.Location = new System.Drawing.Point(138, 98);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(141, 38);
            this.cbBaudRate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "波特率";
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBit.Location = new System.Drawing.Point(138, 153);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(141, 38);
            this.cbStopBit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "停止位";
            // 
            // cbParityBit
            // 
            this.cbParityBit.FormattingEnabled = true;
            this.cbParityBit.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.cbParityBit.Location = new System.Drawing.Point(138, 263);
            this.cbParityBit.Name = "cbParityBit";
            this.cbParityBit.Size = new System.Drawing.Size(141, 38);
            this.cbParityBit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "校验位";
            // 
            // cbDataBit
            // 
            this.cbDataBit.FormattingEnabled = true;
            this.cbDataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbDataBit.Location = new System.Drawing.Point(138, 208);
            this.cbDataBit.Name = "cbDataBit";
            this.cbDataBit.Size = new System.Drawing.Size(141, 38);
            this.cbDataBit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据位";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(138, 43);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(141, 38);
            this.cbPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tbDataRX
            // 
            this.tbDataRX.Location = new System.Drawing.Point(6, 37);
            this.tbDataRX.Multiline = true;
            this.tbDataRX.Name = "tbDataRX";
            this.tbDataRX.ReadOnly = true;
            this.tbDataRX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataRX.Size = new System.Drawing.Size(999, 478);
            this.tbDataRX.TabIndex = 1;
            // 
            // gbDataRX
            // 
            this.gbDataRX.Controls.Add(this.tbDataRX);
            this.gbDataRX.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.gbDataRX.Location = new System.Drawing.Point(12, 12);
            this.gbDataRX.Name = "gbDataRX";
            this.gbDataRX.Size = new System.Drawing.Size(1015, 520);
            this.gbDataRX.TabIndex = 2;
            this.gbDataRX.TabStop = false;
            this.gbDataRX.Text = "数据接收区";
            // 
            // ckbHex
            // 
            this.ckbHex.AutoSize = true;
            this.ckbHex.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ckbHex.Location = new System.Drawing.Point(1044, 425);
            this.ckbHex.Name = "ckbHex";
            this.ckbHex.Size = new System.Drawing.Size(111, 34);
            this.ckbHex.TabIndex = 3;
            this.ckbHex.Text = "16进制";
            this.ckbHex.UseVisualStyleBackColor = true;
            // 
            // btnClearDataRX
            // 
            this.btnClearDataRX.AutoSize = true;
            this.btnClearDataRX.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.btnClearDataRX.Location = new System.Drawing.Point(1177, 415);
            this.btnClearDataRX.Name = "btnClearDataRX";
            this.btnClearDataRX.Size = new System.Drawing.Size(135, 53);
            this.btnClearDataRX.TabIndex = 12;
            this.btnClearDataRX.Text = "清除接收";
            this.btnClearDataRX.UseVisualStyleBackColor = true;
            this.btnClearDataRX.Click += new System.EventHandler(this.btnClearDataRX_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.AutoSize = true;
            this.btnSendData.Enabled = false;
            this.btnSendData.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.btnSendData.Location = new System.Drawing.Point(1035, 586);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(135, 53);
            this.btnSendData.TabIndex = 13;
            this.btnSendData.Text = "发送";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnClearDataTX
            // 
            this.btnClearDataTX.AutoSize = true;
            this.btnClearDataTX.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.btnClearDataTX.Location = new System.Drawing.Point(1177, 586);
            this.btnClearDataTX.Name = "btnClearDataTX";
            this.btnClearDataTX.Size = new System.Drawing.Size(135, 53);
            this.btnClearDataTX.TabIndex = 14;
            this.btnClearDataTX.Text = "清除发送";
            this.btnClearDataTX.UseVisualStyleBackColor = true;
            this.btnClearDataTX.Click += new System.EventHandler(this.btnClearDataTX_Click);
            // 
            // ckbHexSend
            // 
            this.ckbHexSend.AutoSize = true;
            this.ckbHexSend.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ckbHexSend.Location = new System.Drawing.Point(1044, 653);
            this.ckbHexSend.Name = "ckbHexSend";
            this.ckbHexSend.Size = new System.Drawing.Size(157, 34);
            this.ckbHexSend.TabIndex = 15;
            this.ckbHexSend.Text = "16进制发送";
            this.ckbHexSend.UseVisualStyleBackColor = true;
            this.ckbHexSend.CheckedChanged += new System.EventHandler(this.ckbHexSend_CheckedChanged);
            // 
            // ckbAddrn
            // 
            this.ckbAddrn.AutoSize = true;
            this.ckbAddrn.Checked = true;
            this.ckbAddrn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAddrn.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ckbAddrn.Location = new System.Drawing.Point(1044, 693);
            this.ckbAddrn.Name = "ckbAddrn";
            this.ckbAddrn.Size = new System.Drawing.Size(154, 34);
            this.ckbAddrn.TabIndex = 16;
            this.ckbAddrn.Text = "加回车换行";
            this.ckbAddrn.UseVisualStyleBackColor = true;
            // 
            // ssMain
            // 
            this.ssMain.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ssMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWebLink,
            this.tsslDataTXNum,
            this.tsslDataRXNum});
            this.ssMain.Location = new System.Drawing.Point(0, 854);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1336, 35);
            this.ssMain.TabIndex = 17;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslWebLink
            // 
            this.tsslWebLink.IsLink = true;
            this.tsslWebLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsslWebLink.LinkColor = System.Drawing.Color.DimGray;
            this.tsslWebLink.Name = "tsslWebLink";
            this.tsslWebLink.Size = new System.Drawing.Size(239, 30);
            this.tsslWebLink.Text = "www.hanhan0223.cn";
            this.tsslWebLink.Click += new System.EventHandler(this.tsslWebLink_Click);
            // 
            // tsslDataTXNum
            // 
            this.tsslDataTXNum.Name = "tsslDataTXNum";
            this.tsslDataTXNum.Size = new System.Drawing.Size(148, 30);
            this.tsslDataTXNum.Text = "发送：0 字节";
            // 
            // tsslDataRXNum
            // 
            this.tsslDataRXNum.Name = "tsslDataRXNum";
            this.tsslDataRXNum.Size = new System.Drawing.Size(148, 30);
            this.tsslDataRXNum.Text = "接收：0 字节";
            // 
            // ckbSendTimer
            // 
            this.ckbSendTimer.AutoSize = true;
            this.ckbSendTimer.Enabled = false;
            this.ckbSendTimer.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.ckbSendTimer.Location = new System.Drawing.Point(1044, 733);
            this.ckbSendTimer.Name = "ckbSendTimer";
            this.ckbSendTimer.Size = new System.Drawing.Size(131, 34);
            this.ckbSendTimer.TabIndex = 18;
            this.ckbSendTimer.Text = "定时发送";
            this.ckbSendTimer.UseVisualStyleBackColor = true;
            this.ckbSendTimer.CheckedChanged += new System.EventHandler(this.cbSendTimer_CheckedChanged);
            // 
            // tbSendTimer
            // 
            this.tbSendTimer.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbSendTimer.Location = new System.Drawing.Point(1179, 731);
            this.tbSendTimer.Name = "tbSendTimer";
            this.tbSendTimer.Size = new System.Drawing.Size(75, 38);
            this.tbSendTimer.TabIndex = 19;
            this.tbSendTimer.Text = "500";
            this.tbSendTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.label7.Location = new System.Drawing.Point(1257, 735);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "ms/次";
            // 
            // btnSaveData
            // 
            this.btnSaveData.AutoSize = true;
            this.btnSaveData.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.btnSaveData.Location = new System.Drawing.Point(1177, 474);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(135, 53);
            this.btnSaveData.TabIndex = 21;
            this.btnSaveData.Text = "保存数据";
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // tcDataTX
            // 
            this.tcDataTX.Controls.Add(this.tpSingleSend);
            this.tcDataTX.Controls.Add(this.tpMultiSend);
            this.tcDataTX.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tcDataTX.Location = new System.Drawing.Point(12, 539);
            this.tcDataTX.Name = "tcDataTX";
            this.tcDataTX.SelectedIndex = 0;
            this.tcDataTX.Size = new System.Drawing.Size(1015, 312);
            this.tcDataTX.TabIndex = 22;
            this.tcDataTX.SelectedIndexChanged += new System.EventHandler(this.tcDataTX_SelectedIndexChanged);
            // 
            // tpSingleSend
            // 
            this.tpSingleSend.Controls.Add(this.tbDataTX);
            this.tpSingleSend.Location = new System.Drawing.Point(4, 39);
            this.tpSingleSend.Name = "tpSingleSend";
            this.tpSingleSend.Size = new System.Drawing.Size(1007, 269);
            this.tpSingleSend.TabIndex = 0;
            this.tpSingleSend.Text = "单项发送";
            this.tpSingleSend.UseVisualStyleBackColor = true;
            // 
            // tbDataTX
            // 
            this.tbDataTX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDataTX.Location = new System.Drawing.Point(0, 0);
            this.tbDataTX.Multiline = true;
            this.tbDataTX.Name = "tbDataTX";
            this.tbDataTX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataTX.Size = new System.Drawing.Size(1007, 269);
            this.tbDataTX.TabIndex = 2;
            this.tbDataTX.TextChanged += new System.EventHandler(this.tbDataTX_TextChanged);
            // 
            // tpMultiSend
            // 
            this.tpMultiSend.Controls.Add(this.button1);
            this.tpMultiSend.Controls.Add(this.textBox1);
            this.tpMultiSend.Controls.Add(this.checkBox1);
            this.tpMultiSend.Location = new System.Drawing.Point(4, 39);
            this.tpMultiSend.Name = "tpMultiSend";
            this.tpMultiSend.Padding = new System.Windows.Forms.Padding(3);
            this.tpMultiSend.Size = new System.Drawing.Size(1007, 269);
            this.tpMultiSend.TabIndex = 1;
            this.tpMultiSend.Text = "多项发送";
            this.tpMultiSend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(360, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "发送1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 38);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 34);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Hex";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 889);
            this.Controls.Add(this.tcDataTX);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSendTimer);
            this.Controls.Add(this.ckbSendTimer);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.ckbAddrn);
            this.Controls.Add(this.ckbHexSend);
            this.Controls.Add(this.btnClearDataTX);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.btnClearDataRX);
            this.Controls.Add(this.ckbHex);
            this.Controls.Add(this.gbDataRX);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerialPort";
            this.Text = "SerialPort";
            this.Load += new System.EventHandler(this.SerialPort_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDataRX.ResumeLayout(false);
            this.gbDataRX.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcDataTX.ResumeLayout(false);
            this.tpSingleSend.ResumeLayout(false);
            this.tpSingleSend.PerformLayout();
            this.tpMultiSend.ResumeLayout(false);
            this.tpMultiSend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbParityBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDataBit;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tbDataRX;
        private System.Windows.Forms.GroupBox gbDataRX;
        private System.Windows.Forms.CheckBox ckbHex;
        private System.Windows.Forms.Button btnClearDataRX;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.Button btnClearDataTX;
        private System.Windows.Forms.CheckBox ckbHexSend;
        private System.Windows.Forms.CheckBox ckbAddrn;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslWebLink;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataTXNum;
        private System.Windows.Forms.ToolStripStatusLabel tsslDataRXNum;
        private System.Windows.Forms.CheckBox ckbSendTimer;
        private System.Windows.Forms.TextBox tbSendTimer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.TabControl tcDataTX;
        private System.Windows.Forms.TabPage tpSingleSend;
        private System.Windows.Forms.TextBox tbDataTX;
        private System.Windows.Forms.TabPage tpMultiSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

