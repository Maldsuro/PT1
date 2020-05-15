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
        double total = 0;
        double change;
        // DITO DI MO NEED ISA ISAHIN PAG HIWA HIWALAYIN YUNG INDEX 
        private void button1_Click(object sender, EventArgs e)
        {
            description.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            description.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            description.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            description.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            description.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            description.Text = button6.Text;
        }
        // BUTTON ADD QUANTITY
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                int plus = int.Parse(textBox2.Text);
                plus += 1;
                string add = plus.ToString();
                textBox2.Text = add;
            }
            catch
            {
                MessageBox.Show("Wrong input by the user");
            }
        }
        // BUTTON SUBTRACT QUANTITY
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                button11.Enabled = true;
                int minus = int.Parse(textBox2.Text);
                minus -= 1;
                string less = minus.ToString();
                textBox2.Text = less;
                if (textBox2.Text == "0")
                {
                    button11.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Wrong input by the user");
            }
        }

      
        // ETO YUNG SA SUKLI
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // ETO YUNG SA SUKLI
                // payment dito disable mo na sya 
                sukli.Enabled = false;
                // syempre di sya pwede mag type ng presyo 
                textBox1.ReadOnly = true;
                // Eto yung tinype nya na price nung sa payment
                string price = textBox1.Text;
                // convert
                double priceDouble = double.Parse(price);
                // sukli
                change = priceDouble - total;
                Console.WriteLine(price);
                textBox1.Text = change.ToString();
                // next sale na kasi ayan na nakuha na sukli
                nextSale.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Wrong input by the user");

            }
        }
        // ETO SA NEXT SALE
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                // eto yung sa next sale
                // reset mo yung total
                total = 0;
                // disable mo yung another sale
                nextSale.Enabled = false;
                // enable mo yung payment
                Bayad.Enabled = true;
                description.Text = "";
                // clear mo yung laman ni listbox
                listBox1.Items.Clear();
                // enable mo si listbox
                listBox1.Enabled = true;
                // clear mo laman ng sa taas kung san nag shshow yung price
                textBox1.Text = "0.00";
                // quantity back to 1 
                textBox2.Text = "1";
                // enable mo si add button
                addButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error Input By User");
            }
        }
        // Eto nag buubura
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex != -1)
                {
                    // index ng gustong alisin ni user
                    int z = listBox1.SelectedIndex;
                    // kunin yung price 
                    string alis = listBox1.Items[z].ToString();
                    int length = alis.Length;
                    int indicator = alis.IndexOf("=") + 2;
                    string price = alis.Substring(indicator, length - indicator);
                    // i subtract sa total
                    total -= double.Parse(price);
                    textBox1.Text = total.ToString();
                    listBox1.Items.RemoveAt(z);
                }
            }
            catch
            {
                MessageBox.Show("Wrong input by the user");
            }
        }
        // Code para sa add button
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                // kunin yung quanitty
                string quantity = textBox2.Text;
                double quantityDouble = double.Parse(quantity);
                // Kinuha mo order nya  galing sa description store sa pinili
                string pinili = description.Text;
                // NEED ALISINB YUNG PHP KASI PARA MAKUHA MO YUNG PRICE WALANG @25PHP ANG MATITIRA LANG 25
                pinili = pinili.Replace("Php", "");
                int indicator = pinili.IndexOf("@") + 1;
                int length = pinili.Length;
                // KINUKUHA NETO YUNG DIGIT AFTER NG @      
                string presyo = pinili.Substring(indicator, length - indicator); // RESULT NETO YUNG 25 OR 99 NA PRICE WALA NG PRODUCTNAME@PRICEPHP
                double presyoDouble = double.Parse(presyo);
                // COmpute yung price * sa quantity
                double finalPresyo = presyoDouble * quantityDouble;
                total += finalPresyo;
                // para mag show total price
                textBox1.Text = total.ToString() + " Php";
                listBox1.Items.Add(description.Text + " X " + quantityDouble + " = " + finalPresyo.ToString());
                description.Text = string.Empty;
                // balik mo sa 1 quantity
                textBox2.Text = "1";
            }
            catch
            {
                MessageBox.Show("Wrong input by the user");
            }
        }

        // Code sa payment
        private void Bayad_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            // Syempre bawal na mag dagdag kase babayad na
            addButton.Enabled = false;
            // Pwede na mag type kase babayad na
            textBox1.ReadOnly = false;
            // disable payment
            Bayad.Enabled = false;
            // enable change
            sukli.Enabled = true;
            textBox1.Focus();
            listBox1.Enabled = false;
        }

        // If yung quantity mo 1 disable mo si - else enable mo
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            if (int.Parse(textBox2.Text) ==1 )
            {
                button11.Enabled = false;
            }
            else
            {
                button11.Enabled = true;
            }
        }
    }
}
