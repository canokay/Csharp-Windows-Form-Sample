using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_v1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi1, sayi2,sonuc;

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label1.Text = Convert.ToString(sonuc);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label1.Text = Convert.ToString(sonuc);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//Eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//Eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//Bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//Eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//Eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//Bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label1.Text= Convert.ToString(sonuc); 

        }
    }
}
