using ACM.BL;
using System;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class OrderWin : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
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


            // using named parameters for flags
            orderContoller.PlaceOrder(customer, order, payment, 
                                      allowSplitOrders:false, emailReceipt:true);
        }


    }
}