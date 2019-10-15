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

namespace CashRegister
{
    public partial class Form1 : Form
    {
        const double BURGER = 2.00;
        const double FRIES = 1.00;
        const double  DRINKS = 0.85;
        const double  TAX_RATE = 0.13;

        double burger;
        double fries;
        double drinks;
        double totalCost;
        double taxAmount;
        double totalCostIncludingTax;

        public Form1()
        {
            InitializeComponent();
        }

        private void TotalsButton_Click(object sender, EventArgs e)
        {
            //get how many of each item is wanted
            burger = Convert.ToDouble(burgerInput.Text);
            fries = Convert.ToDouble(friesImput.Text);
            drinks = Convert.ToDouble(drinksImput.Text);


            //calculate your totals // 3 burgers, 2 fries, 3 drinks
            totalCost = burger * BURGER + fries * FRIES + drinks * DRINKS;
            //tax amount = total cost * tax rate
            taxAmount = totalCost * TAX_RATE;
            //total with tax = total cost + tax amount 
            totalCostIncludingTax = totalCost + taxAmount;



            //output variables to the screen
            subTotalLabel.Text = totalCost.ToString("C");
            taxLabel.Text = taxAmount.ToString("C");
            totalLabel.Text = totalCostIncludingTax.ToString("C");

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = receiptLabel.CreateGraphics();
            
            SolidBrush wordBrush = new SolidBrush(Color.Gold);
            Font wordFont = new Font("Courier New", 15);

            g.DrawString("Huskies Food Inc. \n\n Order Number 115 \n\n October 15, 2019" + 
                "\n\nBurgers       " + burger + 
                "\n\nFries         " + fries +  
                "\n\nDrinks        " + drinks + 
                "\n\nSubtotal      " + totalCost.ToString("C") + 
                "\n\nTax           " + taxAmount.ToString("C") + 
                "\n\nTotal         " + totalCostIncludingTax.ToString("C") + 
                "\n\nHave A Nice Day", wordFont, wordBrush, 10, 10);
        }
    }
}
