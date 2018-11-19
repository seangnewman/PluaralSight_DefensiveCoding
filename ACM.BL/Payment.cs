using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{

    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }
    public class Payment
    {
       

        public int PaymentType { get; set; }
        public void ProcessPayment()
        {
            PaymentType paymentTypeOption;
            if(!Enum.TryParse(this.PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType)); 
            }
            
            // Process the payment

            switch (paymentTypeOption)
            {
                case ACM.BL.PaymentType.CreditCard:
                    // Credit Card
                    break;
                case ACM.BL.PaymentType.PayPal:
                    // Paypal
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
