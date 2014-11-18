using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch08Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //在工具栏中添加一个按钮控件，位于中间，双击按钮，添加为鼠标单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Clicked!";
            Button newButton = new Button();
            newButton.Text = "New Button!";
            newButton .Click += new EventHandler(newButton_Click);
            Controls.Add(newButton);
        }
        private  void newButton_Click(object sender,System.EventArgs e)
        {
            ((Button)sender ).Text  = "Clicked!!";
        }
    }
}
