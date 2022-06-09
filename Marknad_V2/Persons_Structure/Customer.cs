using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marknad_V2.Products_Structure;

namespace Marknad_V2.Persons_Structure
{
    public class Customer : Person_Build
    {
        public double Cash { get; set; }

        public Customer(string name, string address, int phoneNumber,double cash) : base(name, address, phoneNumber)
        {
            this.Cash = cash;
        }

        public void AddToCart(List<Product> cart, Product product)
        {
            cart.Add(product);
        }
    }
}
