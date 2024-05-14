using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMOD12
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

        private void btn_submit_Click(object sender, EventArgs e)
        {
            ouput.Text = this.CariTandaBilangan(Convert.ToInt32(input.Text));
        }


        public string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "Bilangan Nol";
            }
            else if (a > 0)
            {
                return "Bilangan Positif";
            }
            else
            {
                return "Bilangan Negatif";
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void ouput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
