using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        #region Вывод чисел с кнопок;
        private void button17_Click(object sender, EventArgs e)//0
        {
            textBox1.Text = textBox1.Text + 0;
            textBox2.Text = textBox2.Text + 0;
        }

        private void button5_Click(object sender, EventArgs e)//1
        {
            
            textBox1.Text = textBox1.Text + 1;
        }

        private void button6_Click(object sender, EventArgs e)//2
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)//3
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e)//4
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void button10_Click(object sender, EventArgs e)//5
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e)//6
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button13_Click(object sender, EventArgs e)//7
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void button14_Click(object sender, EventArgs e)//8
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button15_Click(object sender, EventArgs e)//9
        {
            textBox1.Text = textBox1.Text + 9;
        }
        #endregion

        #region Математические операции;
        private void button4_Click(object sender, EventArgs e)// сложенние
        {
            a = float.Parse(textBox1.Text);            
            textBox1.Clear();
            count = 1;
            textBox2.Text = a.ToString() + "+";

        }

        private void button8_Click(object sender, EventArgs e)//вычитание
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            textBox2.Text = a.ToString() + "-";

        }

        private void button12_Click(object sender, EventArgs e)//умножение
        {
            a = float.Parse(textBox1.Text);
            count = 3;
            textBox1.Clear();
            textBox2.Text = a.ToString() + "*";
        }

        private void button16_Click(object sender, EventArgs e)//деление
        {
            a = float.Parse(textBox1.Text);
            count = 4;
            textBox1.Clear();
            textBox2.Text = a.ToString() + "/";
        }
        #endregion

        private void button19_Click(object sender, EventArgs e)
        {
            calculate();           
            textBox2.Text = "";     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }



        public void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    MessageBox.Show("Произошла ошибка!");
                    break;
            }
        }
    }
}
