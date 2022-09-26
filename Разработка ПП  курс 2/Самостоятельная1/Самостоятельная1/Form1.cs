using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самостоятельная1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xa, xb, xc, ya, yb, yc, p, s, st1, st2, st3;
            try
            {
                xa = Convert.ToDouble(textBox1.Text);
                ya = Convert.ToDouble(textBox6.Text);
                xb = Convert.ToDouble(textBox3.Text);
                yb = Convert.ToDouble(textBox4.Text);
                xc = Convert.ToDouble(textBox2.Text);
                yc = Convert.ToDouble(textBox5.Text);
                st1 = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2));
                st2 = Math.Sqrt(Math.Pow((xc - xb), 2) + Math.Pow((yc - yb), 2));
                st3 = Math.Sqrt(Math.Pow((xa - xc), 2) + Math.Pow((ya - yc), 2));
                if ((st1 + st2 > st3) & (st1 + st3 > st2) & (st2 + st3 > st1))
                {
                    p = st1 + st2 + st3;
                    s = Math.Abs(0.5 * (xa * (yb - yc) + xb * (yc - ya) + xc * (ya - yb)));
                    label4.Text = "Периметр: " + p.ToString("N") + "\n" + "Площадь: " + s.ToString("N");
                }
                else
                {
                    label4.Text = "Треугольник не существует";
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность входных данных", "Внимание!");
            }
        }
    }
}
