using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harf_degistir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string yazi = textBox1.Text;
                string yeni = "";
                Random r = new Random();
                int randomIndex = 0;
                int karakter = yazi.Length;
                for (int i = karakter; i > 0; i--)
                {
                    randomIndex = r.Next(0, karakter);
                    yeni += yazi[randomIndex];
                    yazi = yazi.Remove(randomIndex, 1);
                    karakter = yazi.Length;
                }
                label1.Text = yeni;
        }
    }
}

