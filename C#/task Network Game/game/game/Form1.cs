using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;

namespace game
{
    
    public partial class Form1 : Form
    {
        public string ip;
        public string port;
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string reseive;
        public String text_to_send;
        public int chek=0;
      
        
        
        public Form1()
        {
            InitializeComponent();
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = address.ToString();
                    
                }

            }
        }
        private void play()
        {
            textBox3.Text = "";
            textBox3.Enabled = true;
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.Enabled = true;
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.Enabled = true;
            textBox5.BackColor = Color.White;
            textBox6.Text = "";
            textBox6.Enabled = true;
            textBox6.BackColor = Color.White;
            textBox7.Text = "";
            textBox7.Enabled = true;
            textBox7.BackColor = Color.White;
            textBox8.Text = "";
            textBox8.Enabled = true;
            textBox8.BackColor = Color.White;
            textBox9.Text = "";
            textBox9.Enabled = true;
            textBox9.BackColor = Color.White;
            textBox10.Text = "";
            textBox10.Enabled = true;
            textBox10.BackColor = Color.White;
            textBox11.Text = "";
            textBox11.Enabled = true;
            textBox11.BackColor = Color.White;
            label2.Text = "";
            label1.Text = "ожидаем соперника..";
        }
        private void play2()
        {
            textBox3.Text = "";
            textBox3.Enabled = true;
            textBox3.BackColor = Color.White;
            textBox4.Text = "";
            textBox4.Enabled = true;
            textBox4.BackColor = Color.White;
            textBox5.Text = "";
            textBox5.Enabled = true;
            textBox5.BackColor = Color.White;
            textBox6.Text = "";
            textBox6.Enabled = true;
            textBox6.BackColor = Color.White;
            textBox7.Text = "";
            textBox7.Enabled = true;
            textBox7.BackColor = Color.White;
            textBox8.Text = "";
            textBox8.Enabled = true;
            textBox8.BackColor = Color.White;
            textBox9.Text = "";
            textBox9.Enabled = true;
            textBox9.BackColor = Color.White;
            textBox10.Text = "";
            textBox10.Enabled = true;
            textBox10.BackColor = Color.White;
            textBox11.Text = "";
            textBox11.Enabled = true;
            textBox11.BackColor = Color.White;
            label2.Text = "";
            label1.Text = "ваш ход..";
        }
        private void button2_Click(object sender, EventArgs e)
        {
           label1.Text = "Ожидайте соперника..";
            button2.Visible = false;
            button3.Visible = false;
            
            TcpListener listener = new TcpListener(IPAddress.Any, 123);
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            while (client.Connected)
            {
                try
                {
                    reseive = STR.ReadLine();
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Твой ход"; }));
                    
                    
                    if (reseive == "10")
                    {
                        this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Yellow; textBox3.Text="0"; textBox3.Enabled = false; }));
                    }
                    if (reseive == "11")
                    {
                        this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Yellow; textBox4.Text = "0"; textBox4.Enabled = false; }));
                    }
                    if (reseive == "12")
                    {
                        this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Yellow; textBox5.Text = "0"; textBox5.Enabled = false; }));
                    }
                    if (reseive == "13")
                    {
                        this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Yellow; textBox6.Text = "0"; textBox6.Enabled = false; }));
                    }
                    if (reseive == "14")
                    {
                        this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Yellow; textBox7.Text = "0"; textBox7.Enabled = false; }));
                    }
                    if (reseive == "15")
                    {
                        this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Yellow; textBox8.Text = "0"; textBox8.Enabled = false; }));
                    }
                    if (reseive == "16")
                    {
                        this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Yellow; textBox9.Text = "0"; textBox9.Enabled = false; }));
                    }
                    if (reseive == "17")
                    {
                        this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Yellow; textBox10.Text = "0"; textBox10.Enabled = false; }));
                    }
                    if (reseive == "18")
                    {
                        this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Yellow; textBox11.Text = "0"; textBox11.Enabled = false; }));
                    }

                    //------проверки на победу
                    if (textBox3.Text == "0" & textBox4.Text == "0" & textBox5.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Red; }));
                        this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Red; }));
                        this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));


                    }
                    if (textBox6.Text == "0" & textBox7.Text == "0" & textBox8.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Red; }));
                        this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                        this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    if (textBox9.Text == "0" & textBox10.Text == "0" & textBox11.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Red; }));
                        this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Red; }));
                        this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    if (textBox3.Text == "0" & textBox6.Text == "0" & textBox9.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Red; }));
                        this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Red; }));
                        this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    if (textBox4.Text == "0" & textBox7.Text == "0" & textBox10.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                        this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Red; }));
                        this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    if (textBox5.Text == "0" & textBox8.Text == "0" & textBox11.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Red; }));
                        this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Red; }));
                        this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    if (textBox3.Text == "0" & textBox7.Text == "0" & textBox11.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Red; }));
                        this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                        this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    if (textBox5.Text == "0" & textBox7.Text == "0" & textBox9.Text == "0")
                    {
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                        chek = 1;
                        this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                        this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Red; }));
                        this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Red; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы проиграли!"; }));
                    }
                    //----на нечью-------------
                    if (textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "" & textBox10.Text != "" & textBox11.Text != "" & chek == 0)
                    {
                        this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Gray; }));
                        this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Gray; }));
                        this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Gray; }));
                        this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Gray; }));
                        this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Gray; }));
                        this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Gray; }));
                        this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Gray; }));
                        this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Gray; }));
                        this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Gray; }));
                        this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Ничья!"; }));
                        this.button4.Invoke(new MethodInvoker(delegate () { button4.Visible = true; }));
                    }
                    //-

                    reseive = "";
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            if (client.Connected)
            {
                STW.WriteLine(text_to_send);
                if (text_to_send=="10")
                {
                   this.textBox3.Invoke(new MethodInvoker(delegate () {textBox3.BackColor=Color.Yellow; textBox3.Text="X"; }));
                   this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }

                if (text_to_send == "11")
                {
                    this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Yellow; textBox4.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "12")
                {
                    this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Yellow; textBox5.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "13")
                {
                    this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Yellow; textBox6.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "14")
                {
                    this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Yellow; textBox7.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "15")
                {
                    this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Yellow; textBox8.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "16")
                {
                    this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Yellow; textBox9.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "17")
                {
                    this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Yellow; textBox10.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
                if (text_to_send == "18")
                {
                    this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Yellow; textBox11.Text = "X"; }));
                    this.label1.Invoke(new MethodInvoker(delegate () { label1.Text = "Ход соперника"; }));
                }
            }
            else
            {
                MessageBox.Show("ошибка");
            }
            //------проверки на победу
            if(textBox3.Text=="X" & textBox4.Text == "X" & textBox5.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Red;}));
                this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Red; }));
                this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
                
            }

            if (textBox6.Text == "X" & textBox7.Text == "X" & textBox8.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Red; }));
                this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
            }
            if (textBox9.Text == "X" & textBox10.Text == "X" & textBox11.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Red; }));
                this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Red; }));
                this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
            }
            if (textBox3.Text == "X" & textBox6.Text == "X" & textBox9.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Red; }));
                this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Red; }));
                this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
            }
            if (textBox4.Text == "X" & textBox7.Text == "X" & textBox10.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Red; }));
                this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
            }
            if (textBox5.Text == "X" & textBox8.Text == "X" & textBox11.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Red; }));
                this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Red; }));
                this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
            }
            if (textBox3.Text == "X" & textBox7.Text == "X" & textBox11.Text == "X")
            {
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
                chek = 1;
                this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Red; }));
                this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
            }
            if (textBox5.Text == "X" & textBox7.Text == "X" & textBox9.Text == "X")
            {
                chek = 1;
                this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Red; }));
                this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Red; }));
                this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Red; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Вы победили!"; }));
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
            }
            //----на нечью-------------
            if (textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "" & textBox10.Text != "" & textBox11.Text != "" & chek == 0)
            {
                this.textBox7.Invoke(new MethodInvoker(delegate () { textBox7.BackColor = Color.Gray; }));
                this.textBox9.Invoke(new MethodInvoker(delegate () { textBox9.BackColor = Color.Gray; }));
                this.textBox8.Invoke(new MethodInvoker(delegate () { textBox8.BackColor = Color.Gray; }));
                this.textBox11.Invoke(new MethodInvoker(delegate () { textBox11.BackColor = Color.Gray; }));
                this.textBox10.Invoke(new MethodInvoker(delegate () { textBox10.BackColor = Color.Gray; }));
                this.textBox6.Invoke(new MethodInvoker(delegate () { textBox6.BackColor = Color.Gray; }));
                this.textBox5.Invoke(new MethodInvoker(delegate () { textBox5.BackColor = Color.Gray; }));
                this.textBox4.Invoke(new MethodInvoker(delegate () { textBox4.BackColor = Color.Gray; }));
                this.textBox3.Invoke(new MethodInvoker(delegate () { textBox3.BackColor = Color.Gray; }));
                this.label2.Invoke(new MethodInvoker(delegate () { label2.Text = "Ничья!"; }));
                this.button1.Invoke(new MethodInvoker(delegate () { button1.Visible = true; }));
            }
            //-----------------------------------------
            
            backgroundWorker2.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            client = new TcpClient();
            IPEndPoint IP_end = new IPEndPoint(IPAddress.Parse(ip),123);
            try
            {
                client.Connect(IP_end);
                if (client.Connected)
                {
                    label1.Text="Игра началась: ваш ход";
                    STW = new StreamWriter(client.GetStream());
                    STR = new StreamReader(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "x")
            {
                text_to_send = textBox3.TabIndex.ToString();
                textBox3.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "x")
            {
                text_to_send = textBox4.TabIndex.ToString();
                textBox4.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "x")
            {
                text_to_send = textBox5.TabIndex.ToString();
                textBox5.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "x")
            {
                text_to_send = textBox6.TabIndex.ToString();
                textBox6.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "x")
            {
                text_to_send = textBox7.TabIndex.ToString();
                textBox7.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "x")
            {
                text_to_send = textBox8.TabIndex.ToString();
                textBox8.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "x")
            {
                text_to_send = textBox9.TabIndex.ToString();
                textBox9.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "x")
            {
                text_to_send = textBox10.TabIndex.ToString();
                textBox10.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "x")
            {
                text_to_send = textBox11.TabIndex.ToString();
                textBox11.Enabled = false;
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play();
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            play2();
            button4.Visible = false;
        }
    }
}
