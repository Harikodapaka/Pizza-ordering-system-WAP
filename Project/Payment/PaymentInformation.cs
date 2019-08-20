using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Payment
{
    public class PaymentInformation
    {
        private string paymentMode;
        private string cardNumber;
        private string expiryDate;

        public PaymentInformation(string paymentMode, string cardNumber, string expiryDate)
        {
            this.paymentMode = paymentMode;
            this.cardNumber = cardNumber;
            this.expiryDate = expiryDate;
        }
        public PaymentInformation() { }
        public string PaymentMode { get => paymentMode; set => paymentMode = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }
        public string ExpiryDate { get => expiryDate; set => expiryDate = value; }
    }
}
