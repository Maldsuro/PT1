using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double exPrice1, exPrice2, exPrice3, exPrice4, exPrice5, exPrice6;
        double total = 0;
        double payment, change;
        private void button1_Click(object sender, EventArgs e)
        {
            string food1 = button1.Text;
            int a = food1.IndexOf("@")+1;
            int b = food1.Length;
            string price1 = food1.Substring(a, 2);
            string qty = textBox2.Text;
            int ilan = int.Parse(qty);
            int priceOne = 25;
            exPrice1 = ilan * priceOne;
            listBox1.Items.Add(qty + " x " + food1 + " = " + exPrice1.ToString());
            total += exPrice1;
            textBox1.Text = ("Total: " + total.ToString() + ".00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string food2 = button2.Text;
            int a = food2.IndexOf("@") + 1;
            int b = food2.Length;
            string price1 = food2.Substring(a, 2);
            string qty = textBox2.Text;
            int ilan = int.Parse(qty);
            int priceOne = 109;
            exPrice2 = ilan * priceOne;
            listBox1.Items.Add(qty + " x " + food2 + " = " + exPrice2.ToString());
            total += exPrice2;
            textBox1.Text = ("Total: " + total.ToString() + ".00");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string food1 = button3.Text;
            int a = food1.IndexOf("@") + 1;
            int b = food1.Length;
            string price1 = food1.Substring(a, 2);
            string qty = textBox2.Text;
            int ilan = int.Parse(qty);
            int priceOne = 109;
            exPrice3 = ilan * priceOne;
            listBox1.Items.Add(qty + " x " + food1 + " = " + exPrice3.ToString());
            total += exPrice3;
            textBox1.Text = ("Total: " + total.ToString() + ".00");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string food1 = button4.Text;
            int a = food1.IndexOf("@") + 1;
            int b = food1.Length;
            string price1 = food1.Substring(a, 2);
            string qty = textBox2.Text;
            int ilan = int.Parse(qty);
            int priceOne = 109;
            exPrice4 = ilan * priceOne;
            listBox1.Items.Add(qty + " x " + food1 + " = " + exPrice4.ToString());
            total += exPrice4;
            textBox1.Text = ("Total: " + total.ToString() + ".00");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string food1 = button5.Text;
            int a = food1.IndexOf("@") + 1;
            int b = food1.Length;
            string price1 = food1.Substring(a, 2);
            string qty = textBox2.Text;
            int ilan = int.Parse(qty);
            int priceOne = 109;
            exPrice5 = ilan * priceOne;
            listBox1.Items.Add(qty + " x " + food1 + " = " + exPrice5.ToString());
            total += exPrice5;
            textBox1.Text = ("Total: " + total.ToString() + ".00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string food1 = button6.Text;
            int a = food1.IndexOf("@") + 1;
            int b = food1.Length;
            string price1 = food1.Substring(a, 2);
            string qty = textBox2.Text;
            int ilan = int.Parse(qty);
            int priceOne = 99;
            exPrice6 = ilan * priceOne;
            listBox1.Items.Add(qty + " x " + food1 + " = " + exPrice6.ToString());
            total += exPrice6;
            textBox1.Text = ("Total: " + total.ToString() + ".00");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           if (textBox2.Text == "0")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button11.Enabled = false; 
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button11.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int plus = int.Parse(textBox2.Text);
            plus += 1;
            string add = plus.ToString();
            textBox2.Text = add;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            int minus = int.Parse(textBox2.Text);
            minus -= 1;
            string less = minus.ToString();
            textBox2.Text = less;
            if (textBox2.Text == "0")
            {
                button11.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button9.Enabled = false;
            if (button7.Enabled == true)
            {
                button7.Enabled = false;
                button8.Enabled = true;
                button9.Enabled = false;
                textBox3.Visible = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Visible = false;
                textBox3.Enabled = false;
                button7.Enabled = true;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox4.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox4.Visible = true;
            double total = int.Parse(textBox1.Text);
            string bayad = textBox3.Text;
            double pay = int.Parse(bayad);
            change = pay - total;
            textBox4.Text = change.ToString();
            //if (bayad > total)
            //{

            //}
            if (button8.Enabled == true)
            {
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = true;
                textBox4.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                textBox3.Enabled = false;
                button7.Enabled = true;
                button9.Enabled = false;
                button8.Enabled = false;
                textBox4.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            if (button9.Enabled == true)
            {
                button7.Enabled = true;
                button8.Enabled = false;
                button9.Enabled = false;
                listBox1.Items.Clear();
                textBox1.Clear();
                total = 0;
                textBox1.Text = (total.ToString()+".00");
                textBox3.Visible = false;
                textBox3.Enabled = false;
                textBox4.Visible = false;
            }
            else
            {
                button7.Enabled = true;
                button8.Enabled = false;
                button9.Enabled = false;
                textBox3.Visible = false;
                textBox3.Enabled = false;
                textBox4.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int z = listBox1.SelectedIndex;
                string alis = listBox1.Items[z].ToString();
                listBox1.Items.RemoveAt(z);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
