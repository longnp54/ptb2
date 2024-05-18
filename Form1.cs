using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptb2
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string s3 = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = textBox3.Text;

            double a = double.Parse(s1);
            double b = double.Parse(s2);
            double c = double.Parse(s3);

            if (a == 0)
            {
                double q = -c / b;
                MessageBox.Show($"Phương trình có một nghiệm \nx= {q:F2}");
            }
            else
            {
                double delta = (double) b*b - 4 * a * c;
                if (delta < 0)
                {
                    MessageBox.Show("Phương trình vô nghiệm");
                }
                else if (delta == 0)
                {
                    double k =  -b / (2 * a);
                    string x = k.ToString();
                    MessageBox.Show($"Phương trình có nghiệm kép \nx= {x:F2}");
                }
                else
                {
                    double i = (-b - Math.Sqrt(delta)) / (2 * a);
                    double j = (-b + Math.Sqrt(delta)) / (2 * a);

                    string x1 = i.ToString();
                    string x2 = j.ToString();
                    MessageBox.Show($"Phương trình có nghiệm phân biệt\nx1 = {x1:F2}\nx2 = {x2:F2}");

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
