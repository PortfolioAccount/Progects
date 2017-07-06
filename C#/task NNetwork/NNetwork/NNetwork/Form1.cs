using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NNetwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VES();
        }
        public double[] I = new double[10];
        public double[,] WIH = new double[10, 6];
        public double[,] WHV = new double[6, 4];
        public double[,] vWIH = new double[10, 6];
        public double[,] vWHV = new double[6, 4];
        public double[] Hout = new double[6];
        public double[] Hxit = new double[6];
        public double[] Vout = new double[4];
        public double[] Vxit = new double[4];
        public double[] G = new double[4];
        public double[] GH = new double[6];

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            I[1] = 0; I[2] = 0; I[3] = 1; checkBox2.Checked = false; checkBox3.Checked = false;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            I[1] = 0; I[2] = 1; I[3] = 0; checkBox1.Checked = false; checkBox3.Checked = false;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            I[1] = 1; I[2] = 0; I[3] = 0; checkBox1.Checked = false; checkBox2.Checked = false;
        }
        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            I[4] = 0; I[5] = 1; I[6] = 0; checkBox6.Checked = false; checkBox5.Checked = false;
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            I[4] = 1; I[5] = 0; I[6] = 0; checkBox4.Checked = false; checkBox5.Checked = false;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            I[4] = 0; I[5] = 0; I[6] = 1; checkBox6.Checked = false; checkBox4.Checked = false;
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            I[7] = 1; I[8] = 0; I[9] = 0; checkBox8.Checked = false; checkBox9.Checked = false;
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            I[7] = 0; I[8] = 0; I[9] = 1; checkBox8.Checked = false; checkBox7.Checked = false;
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            I[7] = 0; I[8] = 1; I[9] = 0; checkBox7.Checked = false; checkBox9.Checked = false;
        }

        public void VES()
        {
            Random rand = new Random();
            double temp1;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    temp1 = Convert.ToDouble(rand.Next(100)) / 100;
                    WIH[i, j] = temp1;
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    temp1 = Convert.ToDouble(rand.Next(100)) / 100;
                    WHV[i, j] = temp1;
                }
            }

        }

        public void rasp()
        {

            for (int i = 1; i <= 5; i++)
            {
                Hout[i] = I[1] * WIH[1, i] + I[2] * WIH[2, i] + I[3] * WIH[3, i] + I[4] * WIH[4, i] + I[5] * WIH[5, i] + I[6] * WIH[6, i] + I[7] * WIH[7, i] + I[8] * WIH[8, i] + I[9] * WIH[9, i];
            }

            for (int i = 1; i <= 5; i++)
            {
                Hxit[i] = (1 / (1 + Math.Exp(-Hout[i])));
            }

            for (int i = 1; i <= 3; i++)
            {
                Vout[i] = Hxit[1] * WHV[1, i] + Hxit[2] * WHV[2, i] + Hxit[3] * WHV[3, i] + Hxit[4] * WHV[4, i] + Hxit[5] * WHV[5, i];
            }

            for (int i = 1; i <= 3; i++)
            {
                Vxit[i] = (1 / (1 + Math.Exp(-Vout[i])));
            }



            textBox1.Text = Convert.ToString(Vxit[1]);
            textBox2.Text = Convert.ToString(Vxit[2]);
            textBox3.Text = Convert.ToString(Vxit[3]);

        }

        public void obuch(double[] I,double G1, double G2, double G3)
        {
            //--------------
            for (int i = 1; i <= 5; i++)
            {
                Hout[i] = I[1] * WIH[1, i] + I[2] * WIH[2, i] + I[3] * WIH[3, i] + I[4] * WIH[4, i] + I[5] * WIH[5, i] + I[6] * WIH[6, i] + I[7] * WIH[7, i] + I[8] * WIH[8, i] + I[9] * WIH[9, i];
            }

            for (int i = 1; i <= 5; i++)
            {
                Hxit[i] = (1 / (1 + Math.Exp(-Hout[i])));
            }

            for (int i = 1; i <= 3; i++)
            {
                Vout[i] = Hxit[1] * WHV[1, i] + Hxit[2] * WHV[2, i] + Hxit[3] * WHV[3, i] + Hxit[4] * WHV[4, i] + Hxit[5] * WHV[5, i];
            }

            for (int i = 1; i <= 3; i++)
            {
                Vxit[i] = (1 / (1 + Math.Exp(-Vout[i])));
            }
            //---------

            G[1] = G1 - Vxit[1];
            G[2] = G2 - Vxit[2];
            G[3] = G3 - Vxit[3];

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    vWHV[i, j] = Hxit[i] * (1 - Hxit[i]) * G[j];
                    WHV[i, j] += vWHV[i, j];
  
                }
            }

            for (int i = 1; i <= 5; i++)
            {
                GH[i] = G[1] * WHV[i, 1] + G[2] * WHV[i, 2] + G[3] * WHV[i, 3];
            }


            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    vWIH[i, j] = I[i] * (1 - I[i]) * GH[j];
                    WIH[i, j] += vWIH[i, j];
                }
            }
        }

        public void cl()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cl();
            rasp();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cl();
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            button1.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cl();
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            button1.Visible = true;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10000; i++)
            {
                I[1] =0; I[2] =0; I[3] =1; I[4] =0; I[5] =0; I[6] =1; I[7] =0; I[8] =0; I[9] =1;
                obuch(I,0,0,1);
                I[1] = 0; I[2] = 1; I[3] = 0; I[4] = 0; I[5] = 1; I[6] = 0; I[7] = 0; I[8] = 1; I[9] = 0;
                obuch(I,0,1,0);
                I[1] = 1; I[2] = 0; I[3] = 0; I[4] = 1; I[5] = 0; I[6] = 0; I[7] = 1; I[8] = 0; I[9] = 0;
                obuch(I,1,0,0);
               
            }
            label7.Text = "Сеть обучена";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
