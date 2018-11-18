﻿using Core.Common;

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

        public void PlaceOrder(Customer customer, 
                               Order order,
                               Payment payment,
                               bool allowSplitOrders, 
                               bool emailReceipt)
        {
            
            customerRepository.Add(customer);
            orderRepository.Add();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();
                emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");

            }
        }
    }
}
