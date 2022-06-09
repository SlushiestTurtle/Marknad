using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marknad_V2.Products_Structure.Furniture
{
    public class Table : Product
    {
        public bool GloriousDetails { get; set; }

        public Table(string name, int amount, double price, string size, string colour, double weight, string material, bool gloriousDetails) : 
            base(name, amount, price, size, colour, weight, material)
        {
            this.GloriousDetails = gloriousDetails;
        }

        public void LoadTables(List<Product> TableList)
        {
            TableList.Add(new Table("Strandtorp", 5, 8746, "260cm*95cm*75cm", "Bergmund svart", 14.8, "Ekfaner", false));
            TableList.Add(new Table("Lerhamn", 2, 1978, "118cm*74cm*75cm", "Svartbrun", 12.7, "Massiv furu", false));
            TableList.Add(new Table("Lerhamn", 2, 1978, "118cm*74cm*75cm", "Vittaryd beige", 12.7, "Massiv furu", false));
        }
    }
}
