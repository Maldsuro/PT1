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

        // BUTTON ADD QUANTITY
        private void button10_Click(object sender, EventArgs e)
        {
            int plus = int.Parse(textBox2.Text);
            plus += 1;
            string add = plus.ToString();
            textBox2.Text = add;
        }

        // BUTTON SUBTRACT QUANTITY
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

      
        // ETO YUNG SA SUKLI
        private void button8_Click(object sender, EventArgs e)
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
            change =priceDouble - total;
            Console.WriteLine(price);
            textBox1.Text = change.ToString();
            // next sale na kasi ayan na nakuha na sukli
            nextSale.Enabled = true;
        }


        // ETO SA NEXT SALE
        private void button9_Click(object sender, EventArgs e)
        {
            // eto yung sa next sale
            
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

        private void addButton_Click(object sender, EventArgs e)
        {
            // kunin yung quanitty
            string quantity = textBox2.Text;
            double quantityDouble = double.Parse(quantity);
            // Kinuha mo order nya  galing sa description store sa pinili
            string pinili = description.Text;
            // NEED ALISINB YUNG PHP KASI PARA MAKUHA MO YUNG PRICE WALANG @25PHP ANG MATITIRA LANG 25
            pinili = pinili.Replace("Php", "");          
            int indicator = pinili.IndexOf("@")+1;
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
           
        }

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
        }

       

       
    }
}
