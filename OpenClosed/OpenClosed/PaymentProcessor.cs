using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    // Abstract strategy
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
    // Concrete strategies
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            // Process credit card payment
        }
    }
    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            // Process PayPal payment
        }
    }
    // Context class
    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _paymentStrategy;
        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void ProcessPayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
