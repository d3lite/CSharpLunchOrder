using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double subTotal;
        private double tax;
        private double orderTotal;
        private int optionCounter;

     

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (rdbHamburger.Checked == true)
            {
                if (chkOption1.Checked == true)
                    optionCounter++;
                if (chkOption2.Checked == true)
                    optionCounter++;
                if (chkOption3.Checked == true)
                    optionCounter++;
                subTotal = 6.95 + (.75 * optionCounter);
            }
            if (rdbPizza.Checked == true)
            {
                if (chkOption1.Checked == true)
                    optionCounter++;
                if (chkOption2.Checked == true)
                    optionCounter++;
                if (chkOption3.Checked == true)
                    optionCounter++;
                subTotal = 5.95 + (.5 * optionCounter);
            }
            if (rdbSalad.Checked == true)
            {
                if (chkOption1.Checked == true)
                    optionCounter++;
                if (chkOption2.Checked == true)
                    optionCounter++;
                if (chkOption3.Checked == true)
                    optionCounter++;
                subTotal = 4.95 + (.25 * optionCounter);
            }

            tax = subTotal * 0.0775;
            orderTotal = subTotal + tax;

            lblSubtotal.Text = subTotal.ToString("C2");
            lblSalesTax.Text = tax.ToString("C2");
            lblOrderTotal.Text = orderTotal.ToString("C2");

            btnPlaceOrder.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbHamburger.Select();
        }

        private void ClearTotals()
        {
            lblOrderTotal.ResetText();
            lblSalesTax.ResetText();
            lblSubtotal.ResetText();
            optionCounter = 0;
            btnPlaceOrder.Enabled = true;
        }

        private void ClearAddOns()
        {
            chkOption1.Checked = false;
            chkOption2.Checked = false;
            chkOption3.Checked = false;
            optionCounter = 0;
            btnPlaceOrder.Enabled = true;
        }

        private void rdbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            gpbAddOnItems.Text = "Add-on items ($.75/each)";
            chkOption1.Text = "Lettuce, tomato, and onions";
            chkOption2.Text = "Ketchup. mustard, and mayo";
            chkOption3.Text = "French Fries";

            ClearAddOns();
            ClearTotals();
        }

        private void rdbPizza_CheckedChanged(object sender, EventArgs e)
        {
            gpbAddOnItems.Text = "Add-on items ($.50/each)";
            chkOption1.Text = "Pepperoni";
            chkOption2.Text = "Sausage";
            chkOption3.Text = "Olives";

            ClearAddOns();
            ClearTotals();
        }

        private void rdbSalad_CheckedChanged(object sender, EventArgs e)
        {
            gpbAddOnItems.Text = "Add-on items ($.25/each)";
            chkOption1.Text = "Croutons";
            chkOption2.Text = "Bacon bits";
            chkOption3.Text = "Bread sticks";

            ClearAddOns();
            ClearTotals();
        }

        private void chkOption1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void chkOption2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void chkOption3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}