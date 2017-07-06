using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xml_reader
{
     using System.Xml.Linq;
    public partial class Form1 : Form
    {
        public static string nomer;
        public static string mark;
        public static string col;
        public static string vl;
        public static string nomer1;
        public static string mark1;
        public static string col1;
        public static string vl1;
        public static string txt1;
        public static string txt2;
        public static string txt3;
        public static string txt4; 
        public Form1()
        {
            InitializeComponent();
           
          //  LoadEmployees();
        }
        


        private void LoadEmployees()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("xmltext.xml");

            foreach(XmlNode node in doc.DocumentElement)
            {
                nomer = node.Attributes[0].Value;
                mark = node["mark"].InnerText;
                col = node["col"].InnerText;
                vl = node["vl"].InnerText;
                listBox1.Items.Add(new Dan(nomer, mark, col,vl));

            }
        }
        //----------------------------------------------------
        public string XMLconnect = "D:/учеба/Projects/xml_reader/xml_reader/xmltext.xml";
        //--------------------------------------------------------
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
           doc.Load(XMLconnect);
         foreach (XmlNode node in doc.DocumentElement)
            {
                nomer = node.Attributes[0].Value;
                mark = node["mark"].InnerText;
                col = node["col"].InnerText;
                vl = node["vl"].InnerText;
                listBox1.Items.Add(new Dan(nomer, mark, col, vl));

            }

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            textBox5.Text = listBox1.Text;
          

        }   

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = false;
            panel2.Visible = true;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            nomer1 = textBox1.Text;
            mark1 = textBox2.Text;
            col1 = textBox3.Text;
            vl1 = textBox4.Text;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(XMLconnect);
            XmlElement xRoot = xDoc.DocumentElement;
            // создаем новый элемент user
            XmlElement userElem = xDoc.CreateElement("Employee");
            // создаем атрибут name
            XmlAttribute nameAttr = xDoc.CreateAttribute("nomer");
            // создаем элементы company и age
            XmlElement companyElem = xDoc.CreateElement("mark");
            XmlElement ageElem = xDoc.CreateElement("col");
            XmlElement vlElem = xDoc.CreateElement("vl");
            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = xDoc.CreateTextNode(nomer1);
            XmlText companyText = xDoc.CreateTextNode(mark1);
            XmlText ageText = xDoc.CreateTextNode(col1);
            XmlText vlText = xDoc.CreateTextNode(vl1);
            //добавляем узлы
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            vlElem.AppendChild(vlText);
            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(companyElem);
            userElem.AppendChild(ageElem);
            userElem.AppendChild(vlElem);
            xRoot.AppendChild(userElem);
            xDoc.Save(XMLconnect);

            XmlDocument doc = new XmlDocument();
            doc.Load(XMLconnect);

            foreach (XmlNode node in doc.DocumentElement)
            {
                nomer = node.Attributes[0].Value;
                mark = node["mark"].InnerText;
                col = node["col"].InnerText;
                vl = node["vl"].InnerText;
                listBox1.Items.Add(new Dan(nomer, mark, col, vl));
            }
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(XMLconnect);

            foreach (XElement xNode in xDoc.Root.Nodes())
            {
                string nom = listBox1.Text;
                if (xNode.Attribute("nomer").Value == nom)
                {
                    textBox5.Text = xNode.Attribute("nomer").Value;
                    xNode.Remove();
                    xDoc.Save(XMLconnect);
                    Application.Restart();
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //------------------------------------
            XDocument xDoc = XDocument.Load(XMLconnect);

            foreach (XElement xNode in xDoc.Root.Nodes())
            {
                string nom = listBox1.Text;
                if (xNode.Attribute("nomer").Value == nom)
                {
                    textBox5.Text = xNode.Attribute("nomer").Value;
                    xNode.Remove();
                    xDoc.Save(XMLconnect);
                    
                }

            }
            //----------------------------------

                nomer1 = textBox5.Text;
                mark1 = textBox6.Text;
                col1 = textBox7.Text;
                vl1 = textBox8.Text;

            //---------------------------
            XmlDocument Doc = new XmlDocument();
            Doc.Load(XMLconnect);
            XmlElement xRoot = Doc.DocumentElement;
            // создаем новый элемент user
            XmlElement userElem = Doc.CreateElement("Employee");
            // создаем атрибут name
            XmlAttribute nameAttr = Doc.CreateAttribute("nomer");
            // создаем элементы company и age
            XmlElement companyElem = Doc.CreateElement("mark");
            XmlElement ageElem = Doc.CreateElement("col");
            XmlElement vlElem = Doc.CreateElement("vl");
            // создаем текстовые значения для элементов и атрибута
            XmlText nameText = Doc.CreateTextNode(nomer1);
            XmlText companyText = Doc.CreateTextNode(mark1);
            XmlText ageText = Doc.CreateTextNode(col1);
            XmlText vlText = Doc.CreateTextNode(vl1);
            //добавляем узлы
            nameAttr.AppendChild(nameText);
            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            vlElem.AppendChild(vlText);
            userElem.Attributes.Append(nameAttr);
            userElem.AppendChild(companyElem);
            userElem.AppendChild(ageElem);
            userElem.AppendChild(vlElem);
            xRoot.AppendChild(userElem);
            Doc.Save(XMLconnect);
            Application.Restart();

            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
