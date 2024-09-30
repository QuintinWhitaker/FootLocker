using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // input sound
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Hello_SoundBible_com_1812488315);
                sp.Play();
                //input sound
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
            catch
            {
               //Error inputs
                subtotalOutput.Text = $"ERROR";
                taxOutput.Text = $"ERROR";
                totalOutput.Text = $"ERROR";
            }


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //input sound
                SoundPlayer sp = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
                sp.Play();
                //input cash tendered
                cashTendered = Convert.ToDouble(cashtenderedOutput.Text);

                if (cashTendered >= total) ;
                {

                }
                change = cashTendered - total;
                changeOutput.Text = $"{change.ToString("C")}";
            }
            catch
            {  //Error inputs
                subtotalOutput.Text = $"ERROR";
                taxOutput.Text = $"ERROR";
                totalOutput.Text = $"ERROR";
            }

        }

        private void receiptLabel_Click(object sender, EventArgs e)
        {
           



        }

        private void printLabel_Click(object sender, EventArgs e)
        {
          // input sound
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
           sp.Play();
           //input data 
            receiptLabel.Text += $"\n Order Number #{order++}";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n September 26th, 2024";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\n\nshoes x{shoes} @ $50.25";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nhats x{hats}     @ $25.00";
            Refresh();
            Thread.Sleep(1000);
            receiptLabel.Text += $"\nshirts x{shirts} @ $13.50";
            Refresh();
            Thread.Sleep(750);
            receiptLabel.Text += $"\n\n Subtotal:           {subTotal.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            receiptLabel.Text += $"\n tax:                {taxAmount.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            receiptLabel.Text += $"\n total:              {total.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            receiptLabel.Text += $"\n tendered:           {cashTendered.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            receiptLabel.Text += $"\n change:             {change.ToString("C")}";
            Refresh();
            Thread.Sleep(750);
            receiptLabel.Text += $"\n\nThanks for Shopping With Us. ";

        }

        private void neworderLabel_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Properties.Resources.Loud_Bang_Osama_Bin_Laden_925764326);
            sp.Play();

            shoesOutput.Text = $"";
            hatsOutput.Text = $"";
            shirtsOutput.Text = $"";
            receiptLabel.Text = $"";
            subtotalOutput.Text = $"";
            taxOutput.Text = $"";
            totalOutput.Text = $"";
            cashtenderedOutput.Text = $"";
            changeOutput.Text = $"";

        }
    }
}
