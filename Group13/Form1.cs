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

namespace Group13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Baud = { "1", "2", "4", "8", "9600" };
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nameport = SerialPort.GetPortNames();
            cbCom.Items.AddRange(nameport);
            cbBauDrate.Items.AddRange(Baud);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void standardControl1_Load(object sender, EventArgs e)
        {

        }
        bool Lamp1 = true;
        bool Lamp2 = true;
        bool Lamp3 = true;
        bool Lamp4 = true;
        bool Arch = true;
        private void btnLamp4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbBauDrate.Text=="" || cbCom.Text=="")
                {
                    MessageBox.Show("Ban chua nhap du thong tin","Thong bao");
                }
                
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    btnConnect.Text = "CONNECT";
                }
                else
                {
                    serialPort1.PortName = cbCom.Text;
                    serialPort1.BaudRate = int.Parse(cbBauDrate.Text);
                    serialPort1.Open();
                    btnConnect.Text = "DISCONNECT";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Arch == true)
                {
                    serialPort1.Write("j");
                    btnArch.Text = "ON";
                    Arch = false;
                }
                else
                {
                    serialPort1.Write("k");
                    btnArch.Text = "OFF";
                    Arch = true;
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }
        
        private void btnLamp1_Click(object sender, EventArgs e)
        {
            try
            {
                if(Lamp1 == true)
                {
                    serialPort1.Write("a");
                    btnLamp1.Text = "ON";
                    Lamp1 = false;
                }
                else
                {
                    serialPort1.Write("b");
                    btnLamp1.Text = "OFF";
                    Lamp1 = true;
                }    
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
        }

        private void btnLamp2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lamp2 == true)
                {
                    serialPort1.Write("c");
                    btnLamp2.Text = "ON";
                    Lamp2 = false;
                }
                else
                {
                    serialPort1.Write("d");
                    btnLamp2.Text = "OFF";
                    Lamp2 = true;
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnLamp3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Lamp3 == true)
                {
                    serialPort1.Write("e");
                    btnLamp3.Text = "ON";
                    Lamp3 = false;
                }
                else
                {
                    serialPort1.Write("f");
                    btnLamp3.Text = "OFF";
                    Lamp3 = true;
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }

        private void btnLamp4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Lamp4 == true)
                {
                    serialPort1.Write("g");
                    btnLamp4.Text = "ON";
                    Lamp4 = false;
                }
                else
                {
                    serialPort1.Write("h");
                    btnLamp4.Text = "OFF";
                    Lamp4 = true;
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }
    }
}
