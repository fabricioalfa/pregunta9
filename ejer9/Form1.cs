﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient(); 
            ws.ModificarPersona(Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            ws.AgregarPersona(textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ws = new ServiceReference1.WebService1SoapClient();
            ws.EliminarPersona(Convert.ToInt16(textBox1.Text));
        }
    }
}
