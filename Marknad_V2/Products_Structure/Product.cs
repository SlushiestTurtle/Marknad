using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marknad_V2.Products_Structure
{
    public class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public double Weight { get; set; }
        public string Material { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product(string name, int amount, double price, string size, string colour, double weight, string material)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
            this.Size = size;
            this.Colour = colour;
            this.Weight = weight;
            this.Material = material;
        }


    }
}
