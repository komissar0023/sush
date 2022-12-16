using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postavte5zdk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // X
            textBox1.Text = "14,26";
            // Y
            textBox2.Text = "-1,22";
            // Z
            textBox3.Text = "0,35";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подсчёт X
            double x = double.Parse(textBox1.Text);
            // Вывод в окно Х
            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();
            // Подсчёт Y
            double y = double.Parse(textBox2.Text);
            // Вывод в окно Y
            textBox4.Text += Environment.NewLine +
            "Y = " + y.ToString();
            // Подсчёт Z
            double Z = double.Parse(textBox3.Text);
            // Вывод в окно Z
            textBox4.Text += Environment.NewLine +
            "Z = " + Z.ToString();
            // Уравнение дерьма
            double a = Math.Cos((x - Math.PI) / 6) + Math.Cos(x - 3, 14 / 6);


        }
    }
}
