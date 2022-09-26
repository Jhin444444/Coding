using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Удаляем из надписи Label2 ненужный текст
            label2.Text = "";
        }
        // Обработчик щелчка по кнопке
        private void button1_Click(object sender, EventArgs e)
        {// Если поле для ввода не пустое:
            if (textBox1.Text != "")
                label2.Text = "Здравствуйте, " + textBox1.Text + "!";
        }
    }
}
