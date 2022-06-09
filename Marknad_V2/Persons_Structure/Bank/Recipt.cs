using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marknad_V2.Products_Structure;


namespace Marknad_V2.Persons_Structure.Bank
{
    public class Recipt
    {
        public List<Product> _recipt { get; set; }
        
        public void AddToRecipt(Product item)
        {
            _recipt.Add(new Product(item.Name, item.Price));
        }
    }
}
