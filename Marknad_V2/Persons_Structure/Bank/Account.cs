using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marknad_V2.Products_Structure;
using Marknad_V2.Persons_Structure;

namespace Marknad_V2.Persons_Structure.Bank
{
    public class Account
    {
        public double TotalPrice { get; set; }
        Customer customer;

        public Account(double totalPrice)
        {
            this.TotalPrice = totalPrice;
        }

        public double CalcPayment(List<Product> cart)
        {
            double totalPrice = 0;
            foreach (Product item in cart)
            {
                totalPrice += item.Price;
            }
            return TotalPrice = totalPrice;
        }

        public bool VerifiedPayment()
        {
            if (TotalPrice > customer.Cash)
            {
                return true;
            }
            return false;
        }
    }
}
