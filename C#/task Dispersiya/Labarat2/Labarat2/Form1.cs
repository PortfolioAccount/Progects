using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarat2
{

    public partial class Form1 : Form
    {

        public int reg = 0;
        public void MyFunc()
        {
            reg = 123456;
        }


        public Form1()
        {
            Form2 f2 = new Form2();

            f2.Owner = this; 
            f2.ShowDialog();

             
            if (reg == 123456)
            {
                InitializeComponent();
            }
            else {
                Application.Exit();
                Close();
            }

        }

        public string Stro;
        public int prover = 0;
        public double temp;
        public string raz;
        public double xx = 0.9876;
        public double xxx;
        public int n;
        public double A = 37.4875;
        public double B = 32.3245;
        public double mod;
        public double pro;
        public string substr;
        public double C = 39.6895;
        public int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0, a15 = 0, a16 = 0, a17 = 0, a18 = 0, a19 = 0, a20 = 0;

       


        private void proverka()
        {
            
            if (n < 0|| n == 0|| Stro == "fool"||n>50000)
            {
                string message = "Значение N должно представлять цело число. В диапозоне  1 <= N <= 50000";
                string caption = "Ошибка";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
                textBox3.Text = "";
                prover = 0;
            }
            else { prover = 1;}
            

            

        }
        public void Chec(double param)
        {
            temp = param;
            if (temp >= 0.0000 & temp < 0.0500)
            {
                a1++;
            }
            if (temp >= 0.0500 & temp < 0.1000)
            {
                a2++;
            }
            if (temp >= 0.1000 & temp < 0.1500)
            {
                a3++;
            }
            if (temp >= 0.1500 & temp < 0.2000)
            {
                a4++;
            }
            if (temp >= 0.2000 & temp < 0.2500)
            {
                a5++;
            }
            if (temp >= 0.2500 & temp < 0.3000)
            {
                a6++;
            }
            if (temp >= 0.3000 & temp < 0.3500)
            {
                a7++;
            }
            if (temp >= 0.35 & temp < 0.4000)
            {
                a8++;
            }
            if (temp >= 0.4 & temp < 0.45)
            {
                a9++;
            }
            if (temp >= 0.45 & temp < 0.5)
            {
                a10++;
            }
            if (temp >= 0.5 & temp < 0.55)
            {
                a11++;
            }
            if (temp >= 0.55 & temp < 0.6)
            {
                a12++;
            }
            if (temp >= 0.6 & temp < 0.65)
            {
                a13++;
            }
            if (temp >= 0.65 & temp < 0.7)
            {
                a14++;
            }
            if (temp >= 0.7 & temp < 0.75)
            {
                a15++;
            }
            if (temp >= 0.75 & temp < 0.8)
            {
                a16++;
            }
            if (temp >= 0.8 & temp < 0.85)
            {
                a17++;
            }
            if (temp > 0.85 & temp < 0.9)
            {
                a18++;
            }
            if (temp >= 0.9 & temp < 0.95)
            {
                a19++;
            }
            if (temp >= 0.95 & temp < 1.00)
            {
                a20++;
            }
        }

        private void charstr(double[] param1)
        {
            chart1.ChartAreas[0].AxisX.Maximum = 1;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 0.05;

            chart1.Series[0].Points.AddXY(0.025, a1);
            chart1.Series[0].Points.AddXY(0.075, a2);
            chart1.Series[0].Points.AddXY(0.125, a3);
            chart1.Series[0].Points.AddXY(0.175, a4);
            chart1.Series[0].Points.AddXY(0.225, a5);
            chart1.Series[0].Points.AddXY(0.275, a6);
            chart1.Series[0].Points.AddXY(0.325, a7);
            chart1.Series[0].Points.AddXY(0.375, a8);
            chart1.Series[0].Points.AddXY(0.425, a9);
            chart1.Series[0].Points.AddXY(0.475, a10);
            chart1.Series[0].Points.AddXY(0.525, a11);
            chart1.Series[0].Points.AddXY(0.575, a12);
            chart1.Series[0].Points.AddXY(0.625, a13);
            chart1.Series[0].Points.AddXY(0.675, a14);
            chart1.Series[0].Points.AddXY(0.725, a15);
            chart1.Series[0].Points.AddXY(0.775, a16);
            chart1.Series[0].Points.AddXY(0.825, a17);
            chart1.Series[0].Points.AddXY(0.875, a18);
            chart1.Series[0].Points.AddXY(0.925, a19);
            chart1.Series[0].Points.AddXY(0.975, a20);
            //-----------------------------------------
            double[] fon = new double[n];
            for (int i = 0; i < n; i++)
            {
                fon[i] = param1[i];

            }
            int[] A = new int[20];
            A[0] = a1; A[1] = a2; A[2] = a3; A[3] = a4; A[4] = a5; A[5] = a6; A[6] = a7; A[7] = a8; A[8] = a9; A[9] = a10; A[10] = a11; A[11] = a12; A[12] = a13; A[13] = a14; A[14] = a15; A[15] = a16; A[16] = a17; A[17] = a18; A[18] = a19; A[19] = a20;


            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (A[j + 1] > A[j])
                    {
                        int z = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = z;

                    }
                }

            }

            if (A[19] == a1) { chart1.Series[0].Points[0].Color = Color.Red; }
            if (A[19] == a2) { chart1.Series[0].Points[1].Color = Color.Red; }
            if (A[19] == a3) { chart1.Series[0].Points[2].Color = Color.Red; }
            if (A[19] == a4) { chart1.Series[0].Points[3].Color = Color.Red; }
            if (A[19] == a5) { chart1.Series[0].Points[4].Color = Color.Red; }
            if (A[19] == a6) { chart1.Series[0].Points[5].Color = Color.Red; }
            if (A[19] == a7) { chart1.Series[0].Points[6].Color = Color.Red; }
            if (A[19] == a8) { chart1.Series[0].Points[7].Color = Color.Red; }
            if (A[19] == a9) { chart1.Series[0].Points[8].Color = Color.Red; }
            if (A[19] == a10) { chart1.Series[0].Points[9].Color = Color.Red; }
            if (A[19] == a11) { chart1.Series[0].Points[10].Color = Color.Red; }
            if (A[19] == a12) { chart1.Series[0].Points[11].Color = Color.Red; }
            if (A[19] == a13) { chart1.Series[0].Points[12].Color = Color.Red; }
            if (A[19] == a14) { chart1.Series[0].Points[13].Color = Color.Red; }
            if (A[19] == a15) { chart1.Series[0].Points[14].Color = Color.Red; }
            if (A[19] == a16) { chart1.Series[0].Points[15].Color = Color.Red; }
            if (A[19] == a17) { chart1.Series[0].Points[16].Color = Color.Red; }
            if (A[19] == a18) { chart1.Series[0].Points[17].Color = Color.Red; }
            if (A[19] == a19) { chart1.Series[0].Points[18].Color = Color.Red; }
            if (A[19] == a20) { chart1.Series[0].Points[19].Color = Color.Red; }

            if (A[0] == a1) { chart1.Series[0].Points[0].Color = Color.Green; }
            if (A[0] == a2) { chart1.Series[0].Points[1].Color = Color.Green; }
            if (A[0] == a3) { chart1.Series[0].Points[2].Color = Color.Green; }
            if (A[0] == a4) { chart1.Series[0].Points[3].Color = Color.Green; }
            if (A[0] == a5) { chart1.Series[0].Points[4].Color = Color.Green; }
            if (A[0] == a6) { chart1.Series[0].Points[5].Color = Color.Green; }
            if (A[0] == a7) { chart1.Series[0].Points[6].Color = Color.Green; }
            if (A[0] == a8) { chart1.Series[0].Points[7].Color = Color.Green; }
            if (A[0] == a9) { chart1.Series[0].Points[8].Color = Color.Green; }
            if (A[0] == a10) { chart1.Series[0].Points[9].Color = Color.Green; }
            if (A[0] == a11) { chart1.Series[0].Points[10].Color = Color.Green; }
            if (A[0] == a12) { chart1.Series[0].Points[11].Color = Color.Green; }
            if (A[0] == a13) { chart1.Series[0].Points[12].Color = Color.Green; }
            if (A[0] == a14) { chart1.Series[0].Points[13].Color = Color.Green; }
            if (A[0] == a15) { chart1.Series[0].Points[14].Color = Color.Green; }
            if (A[0] == a16) { chart1.Series[0].Points[15].Color = Color.Green; }
            if (A[0] == a17) { chart1.Series[0].Points[16].Color = Color.Green; }
            if (A[0] == a18) { chart1.Series[0].Points[17].Color = Color.Green; }
            if (A[0] == a19) { chart1.Series[0].Points[18].Color = Color.Green; }
            if (A[0] == a20) { chart1.Series[0].Points[19].Color = Color.Green; }
            double chec = 0;
            double Max = fon[0];
            double Min = fon[0];
            //-------------------------
            for (int t = 1; t < n; t++)
            {

                if (Min > fon[t])
                {
                    Min = fon[t];
                }
                if (Max < fon[t])
                {
                    Max = fon[t];
                }
            }

            //-------------------------
            double[] D = new double[n];
            chec = 0;
            for (int t = 0; t < n; t++)
            {
                D[t] = Math.Pow((fon[t] - 0.5), 2);
                chec = chec + D[t];
            }
            double des = chec / n;
            label7.Text = label7.Text + Convert.ToString(Max);
            label8.Text = label8.Text + Convert.ToString(Min);
            string val = Convert.ToString(des);
            val = val + "0000";
            String sub = val.Substring(0, 6);
            label9.Text = label9.Text + sub;
            //----------------------------------------
        }
        //==========2==============
        private void charstr1(double[] param1)
        {
            chart2.ChartAreas[0].AxisX.Maximum = 1;
            chart2.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Interval = 0.05;

            chart2.Series[0].Points.AddXY(0.025, a1);
            chart2.Series[0].Points.AddXY(0.075, a2);
            chart2.Series[0].Points.AddXY(0.125, a3);
            chart2.Series[0].Points.AddXY(0.175, a4);
            chart2.Series[0].Points.AddXY(0.225, a5);
            chart2.Series[0].Points.AddXY(0.275, a6);
            chart2.Series[0].Points.AddXY(0.325, a7);
            chart2.Series[0].Points.AddXY(0.375, a8);
            chart2.Series[0].Points.AddXY(0.425, a9);
            chart2.Series[0].Points.AddXY(0.475, a10);
            chart2.Series[0].Points.AddXY(0.525, a11);
            chart2.Series[0].Points.AddXY(0.575, a12);
            chart2.Series[0].Points.AddXY(0.625, a13);
            chart2.Series[0].Points.AddXY(0.675, a14);
            chart2.Series[0].Points.AddXY(0.725, a15);
            chart2.Series[0].Points.AddXY(0.775, a16);
            chart2.Series[0].Points.AddXY(0.825, a17);
            chart2.Series[0].Points.AddXY(0.875, a18);
            chart2.Series[0].Points.AddXY(0.925, a19);
            chart2.Series[0].Points.AddXY(0.975, a20);
            //----------------------------------------
            double[] fon = new double[n];
            for (int i = 0; i < n; i++)
            {
                fon[i] = param1[i];

            }
            int[] A = new int[20];
            A[0] = a1; A[1] = a2; A[2] = a3; A[3] = a4; A[4] = a5; A[5] = a6; A[6] = a7; A[7] = a8; A[8] = a9; A[9] = a10; A[10] = a11; A[11] = a12; A[12] = a13; A[13] = a14; A[14] = a15; A[15] = a16; A[16] = a17; A[17] = a18; A[18] = a19; A[19] = a20;


            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (A[j + 1] > A[j])
                    {
                        int z = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = z;

                    }
                }

            }

            if (A[19] == a1) { chart2.Series[0].Points[0].Color = Color.Red; }
            if (A[19] == a2) { chart2.Series[0].Points[1].Color = Color.Red; }
            if (A[19] == a3) { chart2.Series[0].Points[2].Color = Color.Red; }
            if (A[19] == a4) { chart2.Series[0].Points[3].Color = Color.Red; }
            if (A[19] == a5) { chart2.Series[0].Points[4].Color = Color.Red; }
            if (A[19] == a6) { chart2.Series[0].Points[5].Color = Color.Red; }
            if (A[19] == a7) { chart2.Series[0].Points[6].Color = Color.Red; }
            if (A[19] == a8) { chart2.Series[0].Points[7].Color = Color.Red; }
            if (A[19] == a9) { chart2.Series[0].Points[8].Color = Color.Red; }
            if (A[19] == a10) { chart2.Series[0].Points[9].Color = Color.Red; }
            if (A[19] == a11) { chart2.Series[0].Points[10].Color = Color.Red; }
            if (A[19] == a12) { chart2.Series[0].Points[11].Color = Color.Red; }
            if (A[19] == a13) { chart2.Series[0].Points[12].Color = Color.Red; }
            if (A[19] == a14) { chart2.Series[0].Points[13].Color = Color.Red; }
            if (A[19] == a15) { chart2.Series[0].Points[14].Color = Color.Red; }
            if (A[19] == a16) { chart2.Series[0].Points[15].Color = Color.Red; }
            if (A[19] == a17) { chart2.Series[0].Points[16].Color = Color.Red; }
            if (A[19] == a18) { chart2.Series[0].Points[17].Color = Color.Red; }
            if (A[19] == a19) { chart2.Series[0].Points[18].Color = Color.Red; }
            if (A[19] == a20) { chart2.Series[0].Points[19].Color = Color.Red; }

            if (A[0] == a1) { chart2.Series[0].Points[0].Color = Color.Green; }
            if (A[0] == a2) { chart2.Series[0].Points[1].Color = Color.Green; }
            if (A[0] == a3) { chart2.Series[0].Points[2].Color = Color.Green; }
            if (A[0] == a4) { chart2.Series[0].Points[3].Color = Color.Green; }
            if (A[0] == a5) { chart2.Series[0].Points[4].Color = Color.Green; }
            if (A[0] == a6) { chart2.Series[0].Points[5].Color = Color.Green; }
            if (A[0] == a7) { chart2.Series[0].Points[6].Color = Color.Green; }
            if (A[0] == a8) { chart2.Series[0].Points[7].Color = Color.Green; }
            if (A[0] == a9) { chart2.Series[0].Points[8].Color = Color.Green; }
            if (A[0] == a10) { chart2.Series[0].Points[9].Color = Color.Green; }
            if (A[0] == a11) { chart2.Series[0].Points[10].Color = Color.Green; }
            if (A[0] == a12) { chart2.Series[0].Points[11].Color = Color.Green; }
            if (A[0] == a13) { chart2.Series[0].Points[12].Color = Color.Green; }
            if (A[0] == a14) { chart2.Series[0].Points[13].Color = Color.Green; }
            if (A[0] == a15) { chart2.Series[0].Points[14].Color = Color.Green; }
            if (A[0] == a16) { chart2.Series[0].Points[15].Color = Color.Green; }
            if (A[0] == a17) { chart2.Series[0].Points[16].Color = Color.Green; }
            if (A[0] == a18) { chart2.Series[0].Points[17].Color = Color.Green; }
            if (A[0] == a19) { chart2.Series[0].Points[18].Color = Color.Green; }
            if (A[0] == a20) { chart2.Series[0].Points[19].Color = Color.Green; }
            double chec = 0;
            double Max = fon[0];
            double Min = fon[0];
            //-------------------------
            for (int t = 1; t < n; t++)
            {

                if (Min > fon[t])
                {
                    Min = fon[t];
                }
                if (Max < fon[t])
                {
                    Max = fon[t];
                }
            }
            //-------------------------
            double[] D = new double[n];

            chec = 0;
            for (int t = 0; t < n; t++)
            {
                D[t] = Math.Pow((fon[t] - 0.5), 2);
                chec = chec + D[t];
            }
            double des = chec / n;

            label4.Text = label4.Text + Convert.ToString(Max);
            label2.Text = label2.Text + Convert.ToString(Min);
            string val = Convert.ToString(des);
            val = val + "0000";
            String sub = val.Substring(0, 6);
            label1.Text = label1.Text + sub;
            //----------------------------------------
        }
        //---------------
        private void charstr2(double[] param1)
        {
            chart3.ChartAreas[0].AxisX.Maximum = 1;
            chart3.ChartAreas[0].AxisX.Minimum = 0;
            chart3.ChartAreas[0].AxisX.Interval = 0.05;

            chart3.Series[0].Points.AddXY(0.025, a1);
            chart3.Series[0].Points.AddXY(0.075, a2);
            chart3.Series[0].Points.AddXY(0.125, a3);
            chart3.Series[0].Points.AddXY(0.175, a4);
            chart3.Series[0].Points.AddXY(0.225, a5);
            chart3.Series[0].Points.AddXY(0.275, a6);
            chart3.Series[0].Points.AddXY(0.325, a7);
            chart3.Series[0].Points.AddXY(0.375, a8);
            chart3.Series[0].Points.AddXY(0.425, a9);
            chart3.Series[0].Points.AddXY(0.475, a10);
            chart3.Series[0].Points.AddXY(0.525, a11);
            chart3.Series[0].Points.AddXY(0.575, a12);
            chart3.Series[0].Points.AddXY(0.625, a13);
            chart3.Series[0].Points.AddXY(0.675, a14);
            chart3.Series[0].Points.AddXY(0.725, a15);
            chart3.Series[0].Points.AddXY(0.775, a16);
            chart3.Series[0].Points.AddXY(0.825, a17);
            chart3.Series[0].Points.AddXY(0.875, a18);
            chart3.Series[0].Points.AddXY(0.925, a19);
            chart3.Series[0].Points.AddXY(0.975, a20);
            //----------------------------------------
            double[] fon = new double[n];
            for (int i = 0; i < n; i++)
            {
                fon[i] = param1[i];
            }
            int[] A = new int[20];
            A[0] = a1; A[1] = a2; A[2] = a3; A[3] = a4; A[4] = a5; A[5] = a6; A[6] = a7; A[7] = a8; A[8] = a9; A[9] = a10; A[10] = a11; A[11] = a12; A[12] = a13; A[13] = a14; A[14] = a15; A[15] = a16; A[16] = a17; A[17] = a18; A[18] = a19; A[19] = a20;


            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (A[j + 1] > A[j])
                    {
                        int z = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = z;

                    }
                }

            }

            if (A[19] == a1) { chart3.Series[0].Points[0].Color = Color.Red; }
            if (A[19] == a2) { chart3.Series[0].Points[1].Color = Color.Red; }
            if (A[19] == a3) { chart3.Series[0].Points[2].Color = Color.Red; }
            if (A[19] == a4) { chart3.Series[0].Points[3].Color = Color.Red; }
            if (A[19] == a5) { chart3.Series[0].Points[4].Color = Color.Red; }
            if (A[19] == a6) { chart3.Series[0].Points[5].Color = Color.Red; }
            if (A[19] == a7) { chart3.Series[0].Points[6].Color = Color.Red; }
            if (A[19] == a8) { chart3.Series[0].Points[7].Color = Color.Red; }
            if (A[19] == a9) { chart3.Series[0].Points[8].Color = Color.Red; }
            if (A[19] == a10) { chart3.Series[0].Points[9].Color = Color.Red; }
            if (A[19] == a11) { chart3.Series[0].Points[10].Color = Color.Red; }
            if (A[19] == a12) { chart3.Series[0].Points[11].Color = Color.Red; }
            if (A[19] == a13) { chart3.Series[0].Points[12].Color = Color.Red; }
            if (A[19] == a14) { chart3.Series[0].Points[13].Color = Color.Red; }
            if (A[19] == a15) { chart3.Series[0].Points[14].Color = Color.Red; }
            if (A[19] == a16) { chart3.Series[0].Points[15].Color = Color.Red; }
            if (A[19] == a17) { chart3.Series[0].Points[16].Color = Color.Red; }
            if (A[19] == a18) { chart3.Series[0].Points[17].Color = Color.Red; }
            if (A[19] == a19) { chart3.Series[0].Points[18].Color = Color.Red; }
            if (A[19] == a20) { chart3.Series[0].Points[19].Color = Color.Red; }

            if (A[0] == a1) { chart3.Series[0].Points[0].Color = Color.Green; }
            if (A[0] == a2) { chart3.Series[0].Points[1].Color = Color.Green; }
            if (A[0] == a3) { chart3.Series[0].Points[2].Color = Color.Green; }
            if (A[0] == a4) { chart3.Series[0].Points[3].Color = Color.Green; }
            if (A[0] == a5) { chart3.Series[0].Points[4].Color = Color.Green; }
            if (A[0] == a6) { chart3.Series[0].Points[5].Color = Color.Green; }
            if (A[0] == a7) { chart3.Series[0].Points[6].Color = Color.Green; }
            if (A[0] == a8) { chart3.Series[0].Points[7].Color = Color.Green; }
            if (A[0] == a9) { chart3.Series[0].Points[8].Color = Color.Green; }
            if (A[0] == a10) { chart3.Series[0].Points[9].Color = Color.Green; }
            if (A[0] == a11) { chart3.Series[0].Points[10].Color = Color.Green; }
            if (A[0] == a12) { chart3.Series[0].Points[11].Color = Color.Green; }
            if (A[0] == a13) { chart3.Series[0].Points[12].Color = Color.Green; }
            if (A[0] == a14) { chart3.Series[0].Points[13].Color = Color.Green; }
            if (A[0] == a15) { chart3.Series[0].Points[14].Color = Color.Green; }
            if (A[0] == a16) { chart3.Series[0].Points[15].Color = Color.Green; }
            if (A[0] == a17) { chart3.Series[0].Points[16].Color = Color.Green; }
            if (A[0] == a18) { chart3.Series[0].Points[17].Color = Color.Green; }
            if (A[0] == a19) { chart3.Series[0].Points[18].Color = Color.Green; }
            if (A[0] == a20) { chart3.Series[0].Points[19].Color = Color.Green; }
            double chec = 0;
            //-------------------------
            double Max = fon[0];
            double Min = fon[0];

            for (int t = 1; t < n; t++)
            {

                if (Min > fon[t])
                {
                    Min = fon[t];
                }
                if (Max < fon[t])
                {
                    Max = fon[t];
                }
            }
            //-------------------------
            double[] D = new double[n];

            chec = 0;
            for (int t = 0; t < n; t++)
            {
                D[t] = Math.Pow((fon[t] - 0.5), 2);
                chec = chec + D[t];
            }
            double des = chec / n;

            label12.Text = label12.Text + Convert.ToString(Max);
            label11.Text = label11.Text + Convert.ToString(Min);
            string val = Convert.ToString(des);
            val = val + "0000";
            String sub = val.Substring(0, 6);
            label10.Text = label10.Text + sub;
            //----------------------------------------
        }
        //==============---
        private void charstr3(double[] param1)
        {
            chart4.ChartAreas[0].AxisX.Maximum = 1;
            chart4.ChartAreas[0].AxisX.Minimum = 0;
            chart4.ChartAreas[0].AxisX.Interval = 0.05;

            chart4.Series[0].Points.AddXY(0.025, a1);
            chart4.Series[0].Points.AddXY(0.075, a2);
            chart4.Series[0].Points.AddXY(0.125, a3);
            chart4.Series[0].Points.AddXY(0.175, a4);
            chart4.Series[0].Points.AddXY(0.225, a5);
            chart4.Series[0].Points.AddXY(0.275, a6);
            chart4.Series[0].Points.AddXY(0.325, a7);
            chart4.Series[0].Points.AddXY(0.375, a8);
            chart4.Series[0].Points.AddXY(0.425, a9);
            chart4.Series[0].Points.AddXY(0.475, a10);
            chart4.Series[0].Points.AddXY(0.525, a11);
            chart4.Series[0].Points.AddXY(0.575, a12);
            chart4.Series[0].Points.AddXY(0.625, a13);
            chart4.Series[0].Points.AddXY(0.675, a14);
            chart4.Series[0].Points.AddXY(0.725, a15);
            chart4.Series[0].Points.AddXY(0.775, a16);
            chart4.Series[0].Points.AddXY(0.825, a17);
            chart4.Series[0].Points.AddXY(0.875, a18);
            chart4.Series[0].Points.AddXY(0.925, a19);
            chart4.Series[0].Points.AddXY(0.975, a20);
            //----------------------------------------
            double[] fon = new double[n];
            for (int i = 0; i < n; i++)
            {
                fon[i] = param1[i];
            }
            int[] A = new int[20];
            A[0] = a1; A[1] = a2; A[2] = a3; A[3] = a4; A[4] = a5; A[5] = a6; A[6] = a7; A[7] = a8; A[8] = a9; A[9] = a10; A[10] = a11; A[11] = a12; A[12] = a13; A[13] = a14; A[14] = a15; A[15] = a16; A[16] = a17; A[17] = a18; A[18] = a19; A[19] = a20;


            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (A[j + 1] > A[j])
                    {
                        int z = A[j + 1];
                        A[j + 1] = A[j];
                        A[j] = z;

                    }
                }

            }

            if (A[19] == a1) { chart4.Series[0].Points[0].Color = Color.Red; }
            if (A[19] == a2) { chart4.Series[0].Points[1].Color = Color.Red; }
            if (A[19] == a3) { chart4.Series[0].Points[2].Color = Color.Red; }
            if (A[19] == a4) { chart4.Series[0].Points[3].Color = Color.Red; }
            if (A[19] == a5) { chart4.Series[0].Points[4].Color = Color.Red; }
            if (A[19] == a6) { chart4.Series[0].Points[5].Color = Color.Red; }
            if (A[19] == a7) { chart4.Series[0].Points[6].Color = Color.Red; }
            if (A[19] == a8) { chart4.Series[0].Points[7].Color = Color.Red; }
            if (A[19] == a9) { chart4.Series[0].Points[8].Color = Color.Red; }
            if (A[19] == a10) { chart4.Series[0].Points[9].Color = Color.Red; }
            if (A[19] == a11) { chart4.Series[0].Points[10].Color = Color.Red; }
            if (A[19] == a12) { chart4.Series[0].Points[11].Color = Color.Red; }
            if (A[19] == a13) { chart4.Series[0].Points[12].Color = Color.Red; }
            if (A[19] == a14) { chart4.Series[0].Points[13].Color = Color.Red; }
            if (A[19] == a15) { chart4.Series[0].Points[14].Color = Color.Red; }
            if (A[19] == a16) { chart4.Series[0].Points[15].Color = Color.Red; }
            if (A[19] == a17) { chart4.Series[0].Points[16].Color = Color.Red; }
            if (A[19] == a18) { chart4.Series[0].Points[17].Color = Color.Red; }
            if (A[19] == a19) { chart4.Series[0].Points[18].Color = Color.Red; }
            if (A[19] == a20) { chart4.Series[0].Points[19].Color = Color.Red; }

            if (A[0] == a1) { chart4.Series[0].Points[0].Color = Color.Green; }
            if (A[0] == a2) { chart4.Series[0].Points[1].Color = Color.Green; }
            if (A[0] == a3) { chart4.Series[0].Points[2].Color = Color.Green; }
            if (A[0] == a4) { chart4.Series[0].Points[3].Color = Color.Green; }
            if (A[0] == a5) { chart4.Series[0].Points[4].Color = Color.Green; }
            if (A[0] == a6) { chart4.Series[0].Points[5].Color = Color.Green; }
            if (A[0] == a7) { chart4.Series[0].Points[6].Color = Color.Green; }
            if (A[0] == a8) { chart4.Series[0].Points[7].Color = Color.Green; }
            if (A[0] == a9) { chart4.Series[0].Points[8].Color = Color.Green; }
            if (A[0] == a10) { chart4.Series[0].Points[9].Color = Color.Green; }
            if (A[0] == a11) { chart4.Series[0].Points[10].Color = Color.Green; }
            if (A[0] == a12) { chart4.Series[0].Points[11].Color = Color.Green; }
            if (A[0] == a13) { chart4.Series[0].Points[12].Color = Color.Green; }
            if (A[0] == a14) { chart4.Series[0].Points[13].Color = Color.Green; }
            if (A[0] == a15) { chart4.Series[0].Points[14].Color = Color.Green; }
            if (A[0] == a16) { chart4.Series[0].Points[15].Color = Color.Green; }
            if (A[0] == a17) { chart4.Series[0].Points[16].Color = Color.Green; }
            if (A[0] == a18) { chart4.Series[0].Points[17].Color = Color.Green; }
            if (A[0] == a19) { chart4.Series[0].Points[18].Color = Color.Green; }
            if (A[0] == a20) { chart4.Series[0].Points[19].Color = Color.Green; }
            double chec = 0;
            //-------------------------
            double Max = fon[0];
            double Min = fon[0];

            for (int t = 1; t < n; t++)
            {

                if (Min > fon[t])
                {
                    Min = fon[t];
                }
                if (Max < fon[t])
                {
                    Max = fon[t];
                }
            }
            //-------------------------
            double[] D = new double[n];

            chec = 0;
            for (int t = 0; t < n; t++)
            {
                D[t] = Math.Pow((fon[t] - 0.5), 2);
                chec = chec + D[t];
            }
            double des = chec / n;

            label15.Text = label15.Text + Convert.ToString(Max);
            label14.Text = label14.Text + Convert.ToString(Min);
            string val = Convert.ToString(des);
            val = val + "0000";
            String sub = val.Substring(0, 6);
            label13.Text = label13.Text + sub;
            //----------------------------------------
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Stro = textBox3.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Stro, out Num);
            if (isNum)
            {

                if (textBox3.Text == "")
                {
                    n = 0; proverka();
                }


                else {
                    n = Convert.ToInt32(textBox3.Text);
                    proverka();
                    if (prover == 1)
                    {
                        chart4.Series[0].Points.Clear();
                        cl();
                        label15.Text = "Max=";
                        label14.Text = "Min=";
                        label13.Text = "AVG=";
                        n = Convert.ToInt32(textBox3.Text);

                        int i = 0;
                        double[] fon = new double[n];


                        double X3 = 89;
                        double X2 = X3;
                        double X1 = X2;
                        // ty = ty + 1;
                        // textBox7.Text = Convert.ToString(ty);
                        // double ty = Convert.ToDouble(textBox7.Text);
                        // textBox6.Text = "";
                        do
                        {

                            if (X1 > 0.01)
                            {
                                mod = (Math.Pow(X1, 2)) / 61;
                                mod = Math.Truncate(mod * 10000);
                                mod = mod / 10000 - Math.Truncate((Math.Pow(X1, 2)) / 61);
                                if (mod > 0.025)
                                {
                                    string ind = Convert.ToString(mod) + "0000000";
                                    substr = ind.Substring(3, 4);
                                    mod = Convert.ToDouble("0" + "," + substr);
                                    if (mod > 0)
                                    {
                                        X1 = mod;
                                        // textBox6.Text = textBox6.Text + "  " + Convert.ToString(X1);
                                        Chec(mod);
                                        fon[i] = mod;
                                        i++;
                                    }
                                    else { X1 = X2 - 0.03; X2 = X1; if (X2 <= 0) { X2 = X3; X1 = X3; } }
                                }
                                else { X1 = X2 - 0.03; X2 = X1; if (X2 <= 0) { X2 = X3; X1 = X3; } }
                            }
                            else { X1 = X2 - 0.03; X2 = X1; if (X2 <= 0) { X2 = X3; X1 = X3; } }
                        }

                        while (i < n);
                        charstr3(fon);
                    }
                }
            }
            else { Stro = "fool"; proverka(); }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Stro = textBox3.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Stro, out Num);
            if (isNum)
            {

                if (textBox3.Text == "")
                {
                    n = 0; proverka();
                }


                else {
                    n = Convert.ToInt32(textBox3.Text);
                    proverka();
                    if (prover == 1)
                    {

                        chart3.Series[0].Points.Clear();
                        cl();
                        label12.Text = "Max=";
                        label11.Text = "Min=";
                        label10.Text = "AVG=";
                        n = Convert.ToInt32(textBox3.Text);

                        int i = 0;
                        double[] fon = new double[n];
                        double Z = 2;
                        double con3 = Z;

                        // textBox6.Text = "";
                        do
                        {

                            if (Z > 0.01)
                            {
                                mod = ((A * Z + B) / C);

                                string value;
                                string ind = Convert.ToString(mod);
                                int index = ind.IndexOf(",");
                                value = Convert.ToString(mod) + "000000";
                                substr = value.Substring(index + 1, 4);
                                mod = Convert.ToDouble("0" + "," + substr);
                                if (mod > 0.025)
                                {
                                    Z = mod;
                                    //  textBox6.Text =textBox6.Text+"  "+ Convert.ToString(Z);
                                    Chec(mod);
                                    fon[i] = mod;
                                    i++;
                                }
                                else { con3 = con3 + 0.8798; Z = con3; }
                            }
                            else { con3 = con3 + 0.8798; Z = con3; }

                        }
                        while (i < n);
                        charstr2(fon);
                    }
                }
            }
            else { Stro = "fool"; proverka(); }
        }


        public void cl()
        {
            a1 = 0; a2 = 0; a3 = 0; a4 = 0; a5 = 0; a6 = 0; a7 = 0; a8 = 0; a9 = 0; a10 = 0; a11 = 0; a12 = 0; a13 = 0; a14 = 0; a15 = 0; a16 = 0; a17 = 0; a18 = 0; a19 = 0; a20 = 0;

        }
        //-------- фн
        private void button3_Click(object sender, EventArgs e)
        {
            Stro = textBox3.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Stro, out Num);
            if (isNum)
            {

                if (textBox3.Text == "")
                {
                    n = 0; proverka();
                }


                else {
                    n = Convert.ToInt32(textBox3.Text);
                    proverka();
                    if (prover == 1)
                    {
                        chart2.Series[0].Points.Clear();

                        cl();
                        label4.Text = "Max=";
                        label2.Text = "Min=";
                        label1.Text = "AVG=";
                        n = Convert.ToInt32(textBox3.Text);
                        double[] fon = new double[n];

                        //  double ty = Convert.ToDouble(textBox7.Text);
                        //  xx = ty;
                        xxx = xx;
                        double x;
                        x = xxx;
                        //  ty = ty + 0.0013;
                        // textBox7.Text = Convert.ToString(ty);
                        int i = 0;
                        do
                        {
                            x = Math.Pow(x, 2);
                            if (x > 0.0001)
                            {
                                String value = Convert.ToString(x);
                                int dl = value.Count();
                                if (dl < 9)
                                { value = value + "01000"; }

                                int startIndex = 4;
                                int length = 4;
                                string ind = Convert.ToString(value);
                                startIndex = ind.IndexOf(",");
                                String substring = value.Substring(startIndex + 3, length);
                                substring = "0" + "," + substring;
                                //    textBox6.Text = textBox6.Text + substring + "\n";
                                x = Convert.ToDouble(substring);

                                fon[i] = x;
                                i++;
                                Chec(x);
                            }
                            else
                            {
                                x = xxx - 0.1234;
                                xxx = x;
                                if (xxx <= 0) { x = xx; xxx = xx; }
                            }
                        }

                        while (i < n);
                        //-----------------
                        charstr1(fon);

                        //-----------------
                    }
                }
            }
            else { Stro = "fool"; proverka(); }
        }



        private void button2_Click(object sender, EventArgs e)
        {   Stro = textBox3.Text.Trim();
            int Num;
            bool isNum = int.TryParse(Stro, out Num);
            if (isNum)
            { 
                 
            if (textBox3.Text == "")
            { n = 0; proverka(); }

                      
            else {
                    n = Convert.ToInt32(textBox3.Text);
                    proverka();
                    if (prover == 1)
                    {
                        chart1.Series[0].Points.Clear();

                        label7.Text = "Max=";
                        label8.Text = "Min=";
                        label9.Text = "AVG=";


                        double[] fon = new double[n];
                        cl();
                        Random rand = new Random();
                        double temp1;
                        for (int i = 0; i <= n - 1; i++)
                        {

                            temp1 = Convert.ToDouble(rand.Next(10000)) / 10000;

                            fon[i] = temp1;
                            Chec(temp1);

                        }

                        charstr(fon);
                    }
                }

            }
               else { Stro = "fool"; proverka(); }
     }
    
        
    }
}
