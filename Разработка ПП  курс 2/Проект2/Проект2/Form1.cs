using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k1, k2, k3;
            try
            {
                k1 = Convert.ToDouble(textBox1.Text);
                k2 = Convert.ToDouble(textBox2.Text);
                k3 = k1 + k2;
                textBox3.Text = k3.ToString("N");
            }
            catch
            {if ((textBox1.Text == "") || (textBox2.Text == ""))
                    MessageBox.Show("Введите данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
