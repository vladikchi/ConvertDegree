using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
        }

        private void buttonConverter1_Click(object sender, EventArgs e)
        {

            try
            {
                double textbox1 = Double.Parse(textBoxF1.Text);
                double Conventer = (textbox1 - 32) / 1.8;
                string Converterstring = Conventer.ToString("F2");
                textBoxF2.Text = Converterstring;
            }
            catch 
            {
                string Converterstring1 = "NoN";
                textBoxF2.Text = Converterstring1;
            }
        }

        private void buttonConverter2_Click(object sender, EventArgs e)
        {
            try
            {
                double textbox2 = Double.Parse(textBoxC1.Text);
                double Conventer1 = textbox2 * 1.8 + 32;
                string Converterstring3 = Conventer1.ToString("F2");
                textBoxC2.Text = Converterstring3;
            }
            catch
            {
                string Converterstring2 = "NoN";
                textBoxC2.Text = Converterstring2;
            }

        }

        private void textBoxF1_TextChanged(object sender, EventArgs e)
        {
            textBoxF1.MaxLength = 5;
        }

        private void textBoxC1_TextChanged(object sender, EventArgs e)
        {
            textBoxC1.MaxLength = 5;
        }

        private void textBoxF2_TextChanged(object sender, EventArgs e)
        {
            textBoxF2.MaxLength = 5;
        }

        private void textBoxC2_TextChanged(object sender, EventArgs e)
        {
            textBoxC2.MaxLength = 5;
        }
    }
}
