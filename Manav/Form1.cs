using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmDomatesFiyat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal decFiyat = nmDomatesFiyat.Value * nmDomKilo.Value;
            nmToplamDomKilo.Value += nmDomKilo.Value;
            nmToplamFiyat.Value += decFiyat;
      
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal decFiyat = nmBiberFiyat.Value * nmBiberKilo.Value;
            nmToplaBiberKilo.Value += nmBiberKilo.Value;
            nmToplamFiyat.Value += decFiyat;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            nmDomKilo.Value = 0;
            nmBiberKilo.Value = 0;
            nmToplaBiberKilo.Value = 0;
            nmToplamDomKilo.Value = 0;
            nmToplamFiyat.Value = 0;

        }

        private void nmBiberKilo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
