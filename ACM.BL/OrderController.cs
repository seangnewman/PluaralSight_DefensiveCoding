using Core.Common;
using System;
using System.Diagnostics;
using System.Linq;

namespace ACM.BL
{
    public class OrderController
    {

        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }

        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }

        public OperationResult PlaceOrder(Customer customer, 
                               Order order,
                               Payment payment,
                               bool allowSplitOrders, 
                               bool emailReceipt)
        {
            Debug.Assert(customerRepository != null, "Missing customer repository instance");
            Debug.Assert(orderRepository != null, "Missing order repository instance");
            Debug.Assert(inventoryRepository != null, "Missing inventory repository instance");
            Debug.Assert(emailLibrary != null, "Missing email library instance");

            if ( customer == null)
            {
                throw new ArgumentNullException("Customer instance is null.");
            }
            if (order == null)
            {
                throw new ArgumentNullException("Order instance is null.");
            }
            if (payment == null)
            {
                throw new ArgumentNullException("Payment instance is null.");
            }

            var op = new OperationResult();

            customerRepository.Add(customer);
            orderRepository.Add();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmail();

                if (result.Success)
                {
                    customerRepository.Update();
                    emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
                }
                else
                {
                    // log the message
                    if (result.MessageList.Any())
                    {
                        op.AddMessage(result.MessageList[0]);
                    }
            }

            }
           

            return op;

        }




    }
}
