namespace Lunch_Order
{
    public partial class frmLunchOrder : Form
    {
        /* This application is for calculating the total price 
     * of an order made at restaurant.
     * AUTHOR: Allen F. Horton
     * DATE: 30 March 2023
     */
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        // The prices for each main course
        const decimal HAMBURGER_PRICE = 6.95m;
        const decimal PIZZA_PRICE = 5.95m;
        const decimal SALAD_PRICE = 4.95m;

        // The prices for the add-ons that
        // go with each main course
        const decimal HAMBURGER_ADDON = 0.75m;
        const decimal PIZZA_ADDON = 0.50m;
        const decimal SALAD_ADDON = 0.25m;

        // The percent of tax that must be
        // charged on top of subtotal
        const decimal TAX_PERCENT = 0.05m;

        // The initial value for
        // subTotal
        decimal subTotal = 0;


        // Radios for Main Courses.
        // These allow you to select your main course
        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            grpbxHamburgerAddOns.Visible = true;
            grpbxPizzaAddOns.Visible = false;
            grpbxSaladAddOns.Visible = false;

            if (rdoHamburger.Checked == true)
            {
                subTotal += HAMBURGER_PRICE;
                PizzaAddOnsOff();
                SaladAddOnsOff();
            }
            else
            {

                subTotal -= HAMBURGER_PRICE;
            }

        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            grpbxHamburgerAddOns.Visible = false;
            grpbxPizzaAddOns.Visible = true;
            grpbxSaladAddOns.Visible = false;

            if (rdoPizza.Checked == true)
            {
                subTotal += PIZZA_PRICE;
                HamburgerAddOnsOff();
                SaladAddOnsOff();
            }
            else
            {
                subTotal -= PIZZA_PRICE;
            }

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            grpbxHamburgerAddOns.Visible = false;
            grpbxPizzaAddOns.Visible = false;
            grpbxSaladAddOns.Visible = true;

            if (rdoSalad.Checked == true)
            {
                subTotal += SALAD_PRICE;
                PizzaAddOnsOff();
                HamburgerAddOnsOff();
            }
            else
            {
                subTotal -= SALAD_PRICE;
            }

        }

        /* Hamburger Add-on Checkboxes.  
       * These allow you to add an add-on
       * to your Hamburger order. 
       * Each add-on increases subTotal.
      */
        private void ckbxHamburgerAddOns1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxHamburgerAddOns1.Checked == true)
            {
                subTotal += HAMBURGER_ADDON;
            }
            else
            {

                subTotal -= HAMBURGER_ADDON;
            }
        }

        private void ckbxHamburgerAddOns2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxHamburgerAddOns2.Checked == true)
            {
                subTotal += HAMBURGER_ADDON;
            }
            else
            {
                subTotal -= HAMBURGER_ADDON;
            }
        }

        private void ckbxHamburgerAddOns3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxHamburgerAddOns3.Checked == true)
            {
                subTotal += HAMBURGER_ADDON;
            }
            else
            {
                subTotal -= HAMBURGER_ADDON;
            }

        }

        /* Pizza Add-on Checkboxes.  
         * These allow you to add an add-on
         * to your Pizza order. 
         * Each add-on increases subTotal.
        */
        private void ckbxPizzaAddOns1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxPizzaAddOns1.Checked == true)
            {
                subTotal += PIZZA_ADDON;
            }
            else
            {
                subTotal -= PIZZA_ADDON;
            }
        }

        private void ckbxPizzaAddOns2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxPizzaAddOns2.Checked == true)
            {
                subTotal += PIZZA_ADDON;
            }
            else
            {
                subTotal -= PIZZA_ADDON;
            }
        }

        private void ckbxPizzaAddOns3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxPizzaAddOns3.Checked == true)
            {
                subTotal += PIZZA_ADDON;
            }
            else
            {
                subTotal -= PIZZA_ADDON;
            }
        }

        /* Salad Add-on Checkboxes.  
        * These allow you to add an add-on
        * to your Salad order.
        * Each add-on increases subTotal.
       */
        private void ckbxSaladAddOns1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxSaladAddOns1.Checked == true && rdoSalad.Checked == true)
            {
                subTotal += SALAD_ADDON;
            }
            else
            {
                subTotal -= SALAD_ADDON;
            }
        }

        private void ckbxSaladAddOns2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbxSaladAddOns2.Checked == true && rdoSalad.Checked == true)
            {
                subTotal += SALAD_ADDON;
            }
            else
            {
                subTotal -= SALAD_ADDON;
            }
        }

        private void ckbxSaladAddOns3_CheckedChanged(object sender, EventArgs e)
        {

            if (ckbxSaladAddOns3.Checked == true && rdoSalad.Checked == true)
            {
                subTotal += SALAD_ADDON;
            }
            else
            {
                subTotal -= SALAD_ADDON;
            }
        }

        // The 'Place Order' button.  Causes Subtotal, Tax, and Order Total to display
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // These are variables into which
            // CalculateTaxAndOrderTotal will put
            // the values for the lunch order's calculated tax
            // and over all total.
            decimal orderTax, orderTotal;

            CalculateTaxAndOrderTotal(subTotal, TAX_PERCENT, out orderTax, out orderTotal);

            txtSubtotal.Text = subTotal.ToString("c");
            txtTax.Text = orderTax.ToString("c");
            txtOrderTotal.Text = orderTotal.ToString("c");
        }

        // The 'Reset' button.  Resets form.
        private void btnReset_Click(object sender, EventArgs e)
        {

            HamburgerAddOnsOff();
            PizzaAddOnsOff();
            SaladAddOnsOff();

            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtOrderTotal.Text = "";

        }

        // The 'Exit' button that closes the form 
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// calculates orderTax and orderTotal
        /// </summary>
        private void CalculateTaxAndOrderTotal(decimal subTotal, decimal TAX_PERCENT, out decimal Tax, out decimal Total)
        {

            Tax = subTotal * TAX_PERCENT;
            Tax = Math.Round(Tax, 2);
            Total = subTotal + Tax;


        }



        // Method to uncheck SaladAddOn checkboxes
        private void SaladAddOnsOff()
        {
            ckbxSaladAddOns1.Checked = false;
            ckbxSaladAddOns2.Checked = false;
            ckbxSaladAddOns3.Checked = false;
        }

        // Method to uncheck PizzaAddOn checkboxes
        private void PizzaAddOnsOff()
        {
            ckbxPizzaAddOns1.Checked = false;
            ckbxPizzaAddOns2.Checked = false;
            ckbxPizzaAddOns3.Checked = false;
        }

        // Method to uncheck HamburgerAddOn checkboxes
        private void HamburgerAddOnsOff()
        {
            ckbxHamburgerAddOns1.Checked = false;
            ckbxHamburgerAddOns2.Checked = false;
            ckbxHamburgerAddOns3.Checked = false;
        }
    }
}