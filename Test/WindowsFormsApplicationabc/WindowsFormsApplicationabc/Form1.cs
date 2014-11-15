using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;//添加线程引用
using System.IO.Ports;//添加串口端口的引用
using System.Windows.Forms;

namespace WindowsFormsApplicationabc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossTheadCalls = false; //处理线程错误问题

            //string[] PortName = System.IO.Ports.SerialPort.GetPortNames();//获取串口名字
            string[] PortName = SerialPort.GetPortNames();//获取串口名字
            using System.IO.Ports;//添加串口端口引用
            if(PortName.Length == 0)
            {
               MessageBox.Show("请检查串口链接是否存在问题")
            }
            else
            {
                int i;
                for(i = 0; i < PortName.Length;i++)
                {
                    comboBox1.Items.Add(PortName[i]);
                }
                foreach (SerialPortlPortlBaudset rate in Enum.GetValues(typeof(SerialPortlBaudset)))
                {
                    comboBox2.Items.Add(((int)rate).ToString());
                }
                foreach (SerialPortDatabitsset bitset in Enum.GetValues(typeof(SerialPortDatabitsset)))
                {
                    comboBox3.Items.Add(((int)bitset).ToString());
                }
                foreach (string str in Enum.GetNames(typeof(Parityset)))
                {
                    comboBox4.Items.Add(str);
                }
                foreach (string Sbset in Enum.GetNames(typeof(StopBits)))
                {
                    comboBox5.Items.Add(Sbset);
                }
                //串口端口设置
                ComboBox1.SelectedIndex = 0;
                //this.comboBox1.SelectedIndex = PortName.Length-1;
                  this.comboBox2.SelectedIndex = 8;
                  this.comboBox3.SelectedIndex = 3; 
                  this.comboBox4.SelectedIndex = 0;
                  this.comboBox5.SelectedIndex = 1;
                //端口初始化
                ResetPort();
            }
        }
        private void ResetPort()
        {
            //this.seriaPort1.BreakState = true;//中断状态
            serialPortl.Encoding = Encoding.GetEncoding("GB2312");
            serialPortl.PortName = comboBox1.Text;
            serialPortl.BandRate = int.Parse(comboBox2.Text);
            serialPortl.DartaBits = int.Parse(comboBox3.Text);
            serialPortl.Parity = (Paraty)Enum.Parse(typeof(parityset),this.comboBox4.Text);
            //serialPortl.Parity = (StopBits)Enum.Parse(typeof(Soptbitset),this.comboBox5.Text);

            serialPortl.ReadTimeout = 500;
            serialPortl.WriteTimeout = 1000;
            try 
            {
                serialPortl.Open();
                linkLabel1.Text = "串口已链接";
                timer1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("串口使用中，请选择其他的端口\n","操作提示")
                linkLabel1.Text = "串口未连接";
            }
        }
    }
            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
            //选择波特率
                   serialPort1.BaudRatre = interface.Parse(comboBox2.Text);
            }
            public enum SerialPort1Baudset : int //波特率参数
            {
                BaudRate_75 = 75,
                BaudRate_110 = 110;
                BaudRate_9600 = 9600;

            }
            private void button3_Click(object sender,EventArgs e)
            {
                Application.Exit();
            }
            private void comboBox3_SelectedIndexChanged(object sender,EventArgs e)
            
            
    }
}
