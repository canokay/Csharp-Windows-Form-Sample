using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_KeyPress_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int SAYI
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
            //string YAZI
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = true;//Eğer rakamsa  yazdırmaz.
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//Eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = false;//Bunların dışındaysa hiçbirisini yazdır
            }
        }
    }
}
