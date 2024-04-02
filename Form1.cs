using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;//color changes color to blue when the mouse hover touches the button
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.White;//color turns back to white when mouse hover is not touching the button
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            textBox1.Clear();//erases numbers from textbox1
            textBox2.Clear();//erases numbers from textbox2

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Pink;//color changes to pink when the mouse hover touches the button
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;//color changes back to white when the mouse hover is not touching the button
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=int.Parse(textBox1.Text);//recieves and inserts number as a
            int b=int.Parse(textBox2.Text);//recieves and inserts number as b
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;//answer when a and b is added
                label4.Text="Your Total is "+c.ToString();//answer will be printed to label 4

            }
            else if (radioButton2.Checked)
            {
                c = a - b;//answer when a and b is substracted 
                label4.Text = "The difference is " + c.ToString();//answer will be printed to label 4
                
            }
            else if (radioButton3.Checked)
            {
                c = a * b;//answer when a and b is multiplied
                label4.Text = "Your Product is " + c.ToString();//answer will be printed to label 4

            }
            else if (radioButton4.Checked)
            {
                c=a / b;//answer when a and b is divided
                label4.Text = "Your Quotient is " + c.ToString();//answer will be printed to label 4

            }
            else if (radioButton5.Checked)
            { c = a % b;//answer of the reminder
                label4.Text = "Your Remainder is " + c.ToString();//answer will be printed to label 4
                    }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
