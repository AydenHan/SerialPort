using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Timers;
using System.IO;
using System.Diagnostics;


namespace SerialPort
{
    public partial class SerialPort : Form
    {
        #region 变量

        private string serialPortName;
        private string illegalHexInput = "[^ a-fA-F0-9\r]+?$";

        private int RXnum = 0;
        private int TXnum = 0;
        private int RXNum
        {
            get { return RXnum; }
            set
            {
                if (value != RXnum) RXNumChanged(value);
                RXnum = value;
            }
        }
        private int TXNum
        {
            get { return TXnum; }
            set
            {
                if (value != TXnum) TXNumChanged(value);
                TXnum = value;
            }
        }

        private int selectedTabPage = 0;

        private List<Control>[] multiSendControl = new List<Control>[8];
        private Queue<Button> multiSendBtn = new Queue<Button> { };

        private System.Timers.Timer sendTimer = new System.Timers.Timer();
        //private Stopwatch watch = new Stopwatch();
        

        #endregion

        public SerialPort()
        {
            InitializeComponent();

            multiSendControlInit();
        }

        #region 初始化部分

        private void SerialPort_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            Array.Reverse(ports);
            cbPort.Items.AddRange(ports);
            cbPort.SelectedIndex = cbPort.Items.Count > 0 ? 0 : -1;

            cbBaudRate.Text = "115200";
            cbStopBit.Text = "1";
            cbDataBit.Text = "8";
            cbParityBit.Text = "无";

            // 事件绑定
            sendTimer.Elapsed += new ElapsedEventHandler(sendTimerElapsed);

        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "打开串口") {
                try {
                    serialPort1.PortName = cbPort.Text;
                    serialPortName = cbPort.Text;
                    serialPort1.BaudRate = int.Parse(cbBaudRate.Text);
                    serialPort1.DataBits = int.Parse(cbDataBit.Text);
                    if (cbStopBit.Text == "1")
                        serialPort1.StopBits = StopBits.One;
                    else if (cbStopBit.Text == "1.5")
                        serialPort1.StopBits = StopBits.OnePointFive;
                    else if (cbStopBit.Text == "2")
                        serialPort1.StopBits = StopBits.Two;
                    if (cbParityBit.Text == "无")
                        serialPort1.Parity = Parity.None;
                    else if (cbParityBit.Text == "奇校验")
                        serialPort1.Parity = Parity.Odd;
                    else if (cbParityBit.Text == "偶校验")
                        serialPort1.Parity = Parity.Even;

                    serialPort1.Open();
                    btnOpenPort.Text = "关闭串口";
                }
                catch (Exception err) {
                    MessageBox.Show("打开失败!\n" + err.ToString(), "Error");
                }
            }
            else {
                try {
                    serialPort1.Close();
                }
                catch (Exception) { throw; }

                btnOpenPort.Text = "打开串口";
            }
        }

        // 重载系统消息拦截函数,实现热插拔
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0219) {  // 设备改变
                if (m.WParam.ToInt32() == 0x8004) {     // usb串口拔出
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                    Array.Reverse(ports);
                    cbPort.Items.Clear();
                    cbPort.Items.AddRange(ports);
                    if (btnOpenPort.Text == "关闭串口") {
                        if (!serialPort1.IsOpen) {
                            btnOpenPort.Text = "打开串口";
                            serialPort1.Dispose();
                            cbPort.SelectedIndex = cbPort.Items.Count > 0 ? 0 : -1;
                        }
                        else {
                            cbPort.Text = serialPortName;
                        }
                    }
                    else {
                        cbPort.SelectedIndex = cbPort.Items.Count > 0 ? 0 : -1;
                    }
                }
                else if (m.WParam.ToInt32() == 0x8000) {     // usb串口插入
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();
                    Array.Reverse(ports);
                    cbPort.Items.Clear();
                    cbPort.Items.AddRange(ports);
                    if (btnOpenPort.Text == "关闭串口") {
                        cbPort.Text = serialPortName;
                    }
                    else {
                        cbPort.SelectedIndex = cbPort.Items.Count > 0 ? 0 : -1;
                    }
                }
            }
            base.WndProc(ref m);
        }

        // 多项发送界面初始化
        private void multiSendControlInit()
        {
            multiSendControl[0] = new List<Control> { checkBox1, textBox1, button1 };
            textBox1.TextChanged += newtbTextChanged;
            button1.Click += newbtnClick;

            int offsetX = checkBox1.Width + textBox1.Width + button1.Width + 30;
            int offsetY = button1.Height + 4;
            for (int i = 2; i < 9; i++) {
                CheckBox newcb = new CheckBox();
                newcb.Size = checkBox1.Size;
                newcb.Name = "checkBox" + i.ToString();
                newcb.Text = checkBox1.Text;
                newcb.Location = new Point(checkBox1.Location.X + offsetX * ( i / 5 ), checkBox1.Location.Y + offsetY * ( ( i - 1 ) % 4 ));
                tpMultiSend.Controls.Add(newcb);
                
                TextBox newtb = new TextBox();
                newtb.Size = textBox1.Size;
                newtb.Name = "textBox" + i.ToString();
                newtb.Location = new Point(textBox1.Location.X + offsetX * ( i / 5 ), textBox1.Location.Y + offsetY * ( ( i - 1 ) % 4 ));
                newtb.TextChanged += newtbTextChanged;
                tpMultiSend.Controls.Add(newtb);

                Button newbtn = new Button();
                newbtn.Size = button1.Size;
                newbtn.Name = "button" + i.ToString();
                newbtn.Text = button1.Text;
                newbtn.Location = new Point(button1.Location.X + offsetX * ( i / 5 ), button1.Location.Y + offsetY * ( ( i - 1 ) % 4 ));
                newbtn.Click += newbtnClick;
                tpMultiSend.Controls.Add(newbtn);

                multiSendControl[i - 1] = new List<Control> { newcb, newtb, newbtn };
            }
        }

        #endregion


        #region 数据接收区

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int length = serialPort1.BytesToRead;
            byte[] buff = new byte[length];
            serialPort1.Read(buff, 0, length);
            Invoke(new Action(() => {
                if (ckbHex.Checked) {
                    tbDataRX.AppendText(Tool.bytesToHexStr(buff));
                }
                else {
                    tbDataRX.AppendText(Encoding.Default.GetString(buff));
                }
            }));
            RXNum += length;
        }

        private void btnClearDataRX_Click(object sender, EventArgs e)
        {
            tbDataRX.Clear();
        }


        private void btnSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog DataRXDialog = new SaveFileDialog();
            DataRXDialog.Filter = "(*.txt)|*.txt|(*.*)|*.*";
            DataRXDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".txt";
            if (DataRXDialog.ShowDialog() == DialogResult.OK) {
                StreamWriter stream = new StreamWriter(DataRXDialog.FileName, true);
                stream.Write(tbDataRX.Text);
                stream.Close();
            }
        }

        #endregion


        #region 数据发送区

        // 16进制输入规范函数
        private bool HexInputLimit(string txt)
        {
            if (Regex.IsMatch(txt, illegalHexInput) && txt.Length > 0) {
                MessageBox.Show("非法输入！\n16进制仅允许输入0~9、a~f或A~F", "Error");
                return true;
            }
            return false;
        }

        // 数据发送函数
        private void SendData(string str)
        {
            try {
                if (str.Length > 0) {
                    TXNum += str.Length;
                    if (ckbAddrn.Checked)
                        str += "\r\n";

                    byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(str);
                    serialPort1.Write(bytes, 0, bytes.Length);
                }
            }
            catch (Exception) {
                MessageBox.Show("连接已断开！", "Error");
            }
        }

        //
        // 单项发送事件
        // 
        private void btnSendData_Click(object sender, EventArgs e)
        {
            string str = tbDataTX.Text;
            if (ckbHexSend.Checked)
                str = Tool.HexStrToByteStr(str);
            SendData(str);
        }

        private void tbDataTX_TextChanged(object sender, EventArgs e)
        {
            if (ckbHexSend.Checked) {
                string txt = tbDataTX.Text;
                if (HexInputLimit(txt)) {
                    tbDataTX.Text = txt.Substring(0, txt.Length - 1);
                    tbDataTX.Select(txt.Length, 0);
                }
            }
        }

        private void btnClearDataTX_Click(object sender, EventArgs e)
        {
            tbDataTX.Clear();
        }

        // 16进制发送时禁用回车换行
        private void ckbHexSend_CheckedChanged(object sender, EventArgs e)
        {
            ckbAddrn.Enabled = !ckbHexSend.Checked;
        }

        //
        // 多项发送事件
        //
        private void newtbTextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) {
                if (multiSendControl[i][1] == sender as TextBox) {
                    if (( multiSendControl[i][0] as CheckBox ).Checked) {
                        string str = ( sender as TextBox ).Text;
                        if (HexInputLimit(str)) {
                            ( sender as TextBox ).Text = str.Substring(0, str.Length - 1);
                            ( sender as TextBox ).Select(str.Length, 0);
                        }
                    }
                }
            }
        }

        private void newbtnClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) {
                if (multiSendControl[i][2] == sender as Button) {
                    string str = multiSendControl[i][1].Text;
                    if (( multiSendControl[i][0] as CheckBox ).Checked)
                        str = Tool.HexStrToByteStr(str);
                    SendData(str);
                }
            }
        }

        private void cbSendTimer_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) {
                if (!string.IsNullOrEmpty(multiSendControl[i][1].Text)) {
                    multiSendBtn.Enqueue(multiSendControl[i][2] as Button);
                }
            }

            tbSendTimer.Enabled = !ckbSendTimer.Checked;
            sendTimer.Interval = int.Parse(tbSendTimer.Text);
            sendTimer.Enabled = ckbSendTimer.Checked;
        }

        #endregion


        #region 监听事件

        private void btnOpenPort_TextChanged(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "关闭串口") {
                btnSendData.Enabled = true;
                ckbSendTimer.Enabled = true;
            }
            else {      // 该动作为关闭串口
                btnSendData.Enabled = false;
                ckbSendTimer.Checked = false;
                ckbSendTimer.Enabled = false;
            }
        }

        private void sendTimerElapsed(object sender, EventArgs e)
        {
            if (selectedTabPage == 0) {
                btnSendData_Click(sender, e);
            }
            else if (selectedTabPage == 1) {
                Button temp = multiSendBtn.Dequeue();
                newbtnClick(temp, e);
                multiSendBtn.Enqueue(temp);
            }
        }

        private void RXNumChanged(int value)
        {
            tsslDataRXNum.Text = "接收：" + value.ToString() + " 字节";
        }

        private void TXNumChanged(int value)
        {
            tsslDataTXNum.Text = "发送：" + value.ToString() + " 字节";
        }

        #endregion

        private void tsslWebLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(tsslWebLink.Text);
        }

        private void tcDataTX_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTabPage = tcDataTX.SelectedIndex;
        }
    }

}
