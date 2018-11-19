using ACM.BL;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;

            if(button != null)
            {
                button.Text = "Processing....";
            }
            PlaceOrder();
        }  // End button1_click

        private void PlaceOrder()
        {
            var customer = new Customer();
            // Populate the customer instance

            var order = new Order();
            //Populate the order instance

            // Populate the payment info from UI
            var payment = new Payment();

            // Does the customer want a receipt
     
            var orderContoller = new OrderController();

            try
            {
                // using named parameters for flags
                var op = orderContoller.PlaceOrder(customer, order, payment,
                                          allowSplitOrders: false, emailReceipt: true);

            }
            catch (ArgumentNullException ex)
            {
                // log the issue 
                // display message to the user that the order was not successful
                
            }


           
        }


    }
}