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

namespace QuickCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double buffer;
        public double buffer1;
        public double result;
        public char operation;
        public bool morethantwo=false;
        public int inc=0;

 

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

   

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

   

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            morethantwoguard();
            if (!morethantwo) {
                operation = '+';
                buffer = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                operation = '+';
                buffer1 = Convert.ToDouble(textBox1.Text);
                calc();
                buffer = result;
                textBox1.Clear();
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            morethantwoguard();
          
                buffer1 = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                //textBox1.Text += "= ";
                calc();
                textBox1.Text += Convert.ToString(result);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            morethantwoguard();
            if (!morethantwo)
            {
                operation = '-';
                buffer = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                operation = '-';
                buffer1 = Convert.ToDouble(textBox1.Text);
                calc();
                buffer = result;
                textBox1.Clear();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            morethantwoguard();
            if (!morethantwo)
            {
                operation = '*';
                buffer = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                operation = '*';
                buffer1 = Convert.ToDouble(textBox1.Text);
                buffer = result;
                calc();
                textBox1.Clear();
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            morethantwoguard();
            if (!morethantwo)
            {
                operation = '/';
                buffer = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
            }
            else
            {
                operation = '/';
                buffer1 = Convert.ToDouble(textBox1.Text);
                buffer = result;
                calc();
                textBox1.Clear();
            }
        }
        public void calc()
        {
            switch (operation)
            {
                case '+': result = buffer + buffer1; break;
                case '-': result = buffer - buffer1; break;
                case '/':
                    if (buffer1 != 0)
                    {
                        result = buffer / buffer1;
                    }
                    else
                    {
                        MessageBox.Show("Error","DIV BY 0");
                        clearall();
                    }
                    break;
                case '*': result = buffer * buffer1; break;
                default: MessageBox.Show("Error", "No Operation"); ; break;
            }

           
        }

        private void button17_Click(object sender, EventArgs e)
        {
            clearall();
        }
      

        public void morethantwoguard()
        {
            inc++;
            if(inc >= 2)
            {
                morethantwo = true;
            }
        }
        public void clearall()
        {
            textBox1.Clear();
            result = 0;
            buffer = 0;
            buffer1 = 0;
            morethantwo = false;
            inc = 0;
        }
      
    }

}


