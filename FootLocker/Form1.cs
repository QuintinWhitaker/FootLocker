using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FootLocker
{
    public partial class Form1 : Form
    {
        //global variables
        double shoes;
        double hats;
        double shirts;
        double subTotal;
        double tax;
        double taxAmount;
        double total;
        double cashTendered;
        double change;
        double order = 1;
        
        
        
       

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void hatsOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            shoes = Convert.ToInt16(shoesOutput.Text);
            hats = (int)Convert.ToDouble(hatsOutput.Text);
            shirts = (int)Convert.ToDouble(shirtsOutput.Text);

            subTotal = shoes * 50.25 + hats * 25.00 + shirts * 13.50;
            taxAmount = subTotal * 0.13;
            total = subTotal + taxAmount;



            subtotalOutput.Text = $"{subTotal.ToString("C")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            totalOutput.Text = $"{total.ToString("C")}";



        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            cashTendered = Convert.ToDouble(cashtenderedOutput.Text);

            if (cashTendered >= total);
            {
                
            }
            change = cashTendered - total;
            changeOutput.Text = $"{change.ToString("C")}";
           



        }

        private void receiptLabel_Click(object sender, EventArgs e)
        {
           



        }

        private void printLabel_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
           sp.Play();
            
            receiptLabel.Text += $"\n Order Number #{order++}";
            receiptLabel.Text += $"\n September 26th, 2024";
            receiptLabel.Text += $"\n\nshoes x{shoes} @ $50.25";
            receiptLabel.Text += $"\nhats x{hats}     @ $25.00";
            receiptLabel.Text += $"\nshirts x{shirts} @ $13.50";
            receiptLabel.Text += $"\n\n Subtotal:           {subTotal.ToString("C")}";
            receiptLabel.Text += $"\n tax:                {taxAmount.ToString("C")}";
            receiptLabel.Text += $"\n total:              {total.ToString("C")}";
            receiptLabel.Text += $"\n tendered:           {cashTendered.ToString("C")};          ";
            receiptLabel.Text += $"\n change:             {change.ToString("C")}";
            receiptLabel.Text += $"\n\nThanks for Shopping With Us. ";

        }

        private void neworderLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
