using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_PA9_Joel_Lim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            rb_US.Checked = false;
            rb_Yen.Checked = false;
            rb_Ringgit.Checked = false;
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {
                if (rb_US.Checked)
                {
                    decimal SGD = Convert.ToDecimal(textBox1.Text);
                    decimal ans = SGD * 0.74m;
                    textBox2.Text = ans.ToString();
                }
                else if (rb_Yen.Checked)
                {
                    decimal Yen = Convert.ToDecimal(textBox1.Text);
                    decimal ans = Yen * 81.97m;
                    textBox2.Text = ans.ToString();
                }
                else if (rb_Ringgit.Checked)
                {
                    decimal Ringgit = Convert.ToDecimal(textBox1.Text);
                    decimal ans = Ringgit * 3.01m;
                    textBox2.Text = ans.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error. Please enter a valid number.");
            }
        }

    }
}
