﻿using System;
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
        string[] Baud = { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400" };
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] nameport = SerialPort.GetPortNames();
            cbCom.Items.AddRange(nameport);
            cbBauDrate.Items.AddRange(Baud);

            timer1.Enabled = true;

            chart1.Series["Nhiet do"].Points.AddXY(1, 1);
            chart1.Series["Do am"].Points.AddXY(1, 1);
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

                    chart1.Series["Nhiet do"].Points.Clear();
                    chart1.Series["Do am"].Points.Clear();

                    lbTemp.Text = string.Format("Nhiệt độ = ... °C");
                    lbHum.Text = string.Format("Độ ẩm = ... %RH");

                    MessageBox.Show("Disconnected", "THONG BAO");
                }
                else
                {
                    serialPort1.PortName = cbCom.Text;
                    serialPort1.BaudRate = int.Parse(cbBauDrate.Text);
                    serialPort1.Open();

                    chart1.Series["Nhiet do"].Points.Clear();
                    chart1.Series["Do am"].Points.Clear();

                    btnConnect.Text = "DISCONNECT";

                    MessageBox.Show("Success Connected", "THONG BAO");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi");
            }
        }

        bool Lamp1 = true;
        bool Lamp2 = true;
        bool Lamp3 = true;
        bool Lamp4 = true;
        bool Arch = true;

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

        private void btnLamp4_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string dataIn = serialPort1.ReadTo("\n");
            Data_Parsing(dataIn);
            this.BeginInvoke(new EventHandler(Show_Data));
         }

        private void Show_Data(object sender, EventArgs e)
        {
            if(updateData == true)
            {
                lbTemp.Text = string.Format("Nhiệt độ = {0} °C", nhietdo.ToString());
                lbHum.Text = string.Format("Độ ẩm = {0} %RH", doam.ToString());

                chart1.Series["Nhiet do"].Points.Add(nhietdo);
                chart1.Series["Do am"].Points.Add(doam);
            }
        }

        double nhietdo = 0;
        double doam = 0;
        bool updateData = false;

        private void Data_Parsing(string dataIn)
        {
            sbyte indexOf_startDataCharacter = (sbyte)dataIn.IndexOf("@");
            sbyte indexOfA = (sbyte)dataIn.IndexOf("A");
            sbyte indexOfB = (sbyte)dataIn.IndexOf("B");

            if(indexOfA != -1 && indexOfB != -1 && indexOf_startDataCharacter != -1 )
            {
                try
                {
                    string str_nhietdo = dataIn.Substring(indexOf_startDataCharacter + 1, (indexOfA - indexOf_startDataCharacter) - 1);
                    string str_doam = dataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);

                    nhietdo = Convert.ToDouble(str_nhietdo);
                    doam = Convert.ToDouble(str_doam);

                    updateData = true;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                updateData = false;
            }
        }
    }
}
