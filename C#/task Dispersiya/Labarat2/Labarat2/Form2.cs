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
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
       
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Vadim" & textBox2.Text == "vad123"|| textBox1.Text == "Admin" & textBox2.Text == "adm123" || textBox1.Text == "Admin3" & textBox2.Text == "adm123")
            {

                Form1 frm = (Form1)this.Owner;
                frm.MyFunc(); //MyFunc - это ваша функция основной формы.
                Close();              
               


            }
            else
            {
                label4.Visible = true;
                textBox1.Text = "";
                textBox2.Text = "";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
