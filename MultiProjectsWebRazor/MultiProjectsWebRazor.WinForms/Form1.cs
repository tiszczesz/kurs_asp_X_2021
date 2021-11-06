using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiProjectsWebRazor.Domain;

namespace MultiProjectsWebRazor.WinForms
{
    public partial class Form1 : Form
    {
        private Encrypt enc = new Encrypt();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox2.Text.Trim().Length > 0 ) {
                enc.Key = Convert.ToInt32(numericUpDown1.Value);
                enc.PlainText = textBox2.Text;
                enc.EncText();
                textBox3.Text = enc.EncodingText;
            }
            else {
                MessageBox.Show("Błąd kodowania!!!");
            }

        }
    }
}
