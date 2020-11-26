/*
Sam Wolfgram 
November 26 2020
Cash Register Project
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

//Check the botom of the page for extra stuff.

namespace CashRegister
{
    public partial class burgerKindom : Form
    {
        //setting Variables
        double burgerAmount;
        double poutineAmount;
        double drinkAmount;

        double burgerPrice = 5.99;
        double poutinePrice = 4.49;
        double drinkPrice = 2.99;

        double subTotal;
        double taxAmount;
        double totalPrice;

        int orderNumber = 356;
        double tenderedAmount;
        double changeAmount;
        int tryCode;

        public burgerKindom()
        {
            InitializeComponent();
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting Subtotal, Tax, Total
                burgerAmount = Convert.ToInt32(burgerTextbox.Text);
                poutineAmount = Convert.ToInt32(poutineTexbox.Text);
                drinkAmount = Convert.ToInt32(drinkTextbox.Text);

                double burgerTotal = burgerPrice * burgerAmount;
                double poutineTotal = poutinePrice * poutineAmount;
                double drinkTotal = drinkPrice * drinkAmount;

                subTotal = (burgerTotal) + (poutineTotal) + (drinkTotal);
                taxAmount = subTotal * 0.13;
                totalPrice = subTotal + taxAmount;
                subOutputLabel.Text = $"{subTotal.ToString("C")}";
                taxOutputLabel.Text = $"{taxAmount.ToString("C")}";
                totalOutputLabel.Text = $"{totalPrice.ToString("C")}";
            }
            catch
            {
                //only using numbers
                warningLabel.Text = "Use numbers, or we will kick you out!";
                this.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(750);
                this.BackColor = Color.Gainsboro;
            }
           

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //calculating change.
                burgerAmount = Convert.ToInt32(burgerTextbox.Text);
                poutineAmount = Convert.ToInt32(poutineTexbox.Text);
                drinkAmount = Convert.ToInt32(drinkTextbox.Text);

                double burgerTotal = burgerPrice * burgerAmount;
                double poutineTotal = poutinePrice * poutineAmount;
                double drinkTotal = drinkPrice * drinkAmount;

                subTotal = (burgerTotal) + (poutineTotal) + (drinkTotal);
                taxAmount = subTotal * 0.13;
                totalPrice = subTotal + taxAmount;
                tenderedAmount = Convert.ToInt32(tenderedTextbox.Text);
                changeAmount = tenderedAmount - totalPrice;
                if (tenderedAmount > 0)
                {
                    changeOutputLabel.Text = $"{changeAmount.ToString("C")}";
                }
                else
                {
                    outputLabel.Text = "Give Me Money";
                }
                
            }
            catch
            {
                //only using numbers
                warningLabel.Text = "Use numbers, or we will kick you out!";
                this.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(750);
                this.BackColor = Color.Gainsboro;
                
            }
               
            
        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //printing recepit
                burgerAmount = Convert.ToInt32(burgerTextbox.Text);
                poutineAmount = Convert.ToInt32(poutineTexbox.Text);
                drinkAmount = Convert.ToInt32(drinkTextbox.Text);

                double burgerTotal = burgerPrice * burgerAmount;
                double poutineTotal = poutinePrice * poutineAmount;
                double drinkTotal = drinkPrice * drinkAmount;
                

                subTotal = (burgerTotal) + (poutineTotal) + (drinkTotal);
                taxAmount = subTotal * 0.13;
                totalPrice = (subTotal + taxAmount);
                tenderedAmount = Convert.ToInt32(tenderedTextbox.Text);
                changeAmount = tenderedAmount - totalPrice;

                if (changeAmount > 0)
                {
                    outputLabel.Text += "\nBurger Kingdom";
                    SoundPlayer player = new SoundPlayer(Properties.Resources.glass_ping_Go445_1207030150);
                    player.Play();
                    Refresh();
                    Thread.Sleep(100);

                    outputLabel.Text += $"\n\nOrder Number {orderNumber}";
                    player.Play();
                    Refresh();
                    Thread.Sleep(100);
                    outputLabel.Text += "\nNovember 26 2020";

                    Refresh();
                    Thread.Sleep(750);

                    outputLabel.Text += $"\n\nBurger   x{burgerAmount} @ {burgerTotal}";
                    player.Play();
                    Refresh();
                    Thread.Sleep(100);
                    outputLabel.Text += $"\nPoutine   x{poutineAmount} @ {poutineTotal}";
                    Refresh();
                    Thread.Sleep(100);
                    outputLabel.Text += $"\nDrink   x{drinkAmount} @ {drinkTotal}";

                    Refresh();
                    Thread.Sleep(100);

                    outputLabel.Text += $"\n\nSubTotal   {subTotal.ToString("C")}";
                    player.Play();
                    Refresh();
                    Thread.Sleep(100);
                    outputLabel.Text += $"\nTax   {taxAmount.ToString("C")}";
                    Refresh();
                    Thread.Sleep(100);
                    outputLabel.Text += $"\nTotal   {totalPrice.ToString("C")}";
                    Refresh();
                    Thread.Sleep(100);

                    outputLabel.Text += $"\n\nTendered   {tenderedAmount.ToString("C")}";
                    Refresh();
                    Thread.Sleep(100);
                    outputLabel.Text += $"\nChange   {changeAmount.ToString("C")}";
                    player.Play();
                    Refresh();
                    Thread.Sleep(100);

                    outputLabel.Text += $"\n\nHave a nice Day!";
                }
                else
                {
                    //sending cheaters to jail
                    headerLabel.Text = "Prison";
                    this.Text = "Prison";
                    this.Icon = (Properties.Resources.Prison);
                    outputLabel.Text = "Pay The Full Amount!!";
                    this.BackColor = Color.Black;
                    Refresh();
                    Thread.Sleep(500);
                    this.BackColor = Color.Gainsboro;
                    outputLabel.Text = "Pay The Full Amount!!";
                    subOutputLabel.Text = "$0.00";
                    taxOutputLabel.Text = "$0.00";
                    totalOutputLabel.Text = "$0.00";
                    changeOutputLabel.Text = "$0.00";
                    warningLabel.Text = "";
                    burgerTextbox.Text = "";
                    poutineTexbox.Text = "";
                    drinkTextbox.Text = "";
                    tenderedTextbox.Text = "";
                }
                   
            }
            catch
            {
                warningLabel.Text = "Use numbers, or we will kick you out!";
                this.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(500);
                this.BackColor = Color.Gainsboro;
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            //reset
            orderNumber++;
            outputLabel.Text = "";
            subOutputLabel.Text = "$0.00";
            taxOutputLabel.Text = "$0.00";
            totalOutputLabel.Text = "$0.00";
            changeOutputLabel.Text = "$0.00";
            warningLabel.Text = "";
            burgerTextbox.Text = "";
            poutineTexbox.Text = "";
            drinkTextbox.Text = "";
            tenderedTextbox.Text = "";
            headerLabel.Text = "Burger Kingdom";
            this.Text = "Burger Kingdom";
            this.Icon = (Properties.Resources.Burger);
            codeTextbox.Text = "";
        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "You Found Me!!!";
            Refresh();
            Thread.Sleep(2500);
            headerLabel.Text = "Burger Kingdom";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //secret code
            try
            {
                tryCode = Convert.ToInt32(codeTextbox.Text);
                if (tryCode != 9)
                {
                    outputLabel.Text = "HaHa You're Wrong";
                }
                else
                {
                    Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text = $"\n\n\n\n\nIt is time...";
                    Refresh();
                    Thread.Sleep(750);
                    outputLabel.Text += $"\n3...";
                    Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text += $"\n2...";
                    Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text += $"\n1...";
                    Refresh();
                    Thread.Sleep(1000);
                    outputLabel.Text += $"\nGoodBye";
                    Refresh();
                    Thread.Sleep(1000);
                }
            }
            catch
            {
                warningLabel.Text = "Use numbers, or we will kick you out!";
                this.BackColor = Color.Red;
                Refresh();
                Thread.Sleep(500);
                this.BackColor = Color.Gainsboro;
            }
        }
    }
}


/*
The order number on the receipt go up if you order again.
If the change is negative it will get mad at you.
Not filling in values OR filling in letters will make it mad.
If tendered amount is 0 a special message will apear, and icon changes.
If the code "9" is put into the code box, something special will happen.
*/