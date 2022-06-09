using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marknad_V2.Products_Structure;

namespace Marknad_V2.Products_Structure.Furniture
{
    public class Chair : Product
    {
        public int Legs { get; set; }
        public bool GloriousDetails { get; set; }

        public Chair(string name, int amount, double price, string size, string colour, double weight, string material, int legs, bool gloriousDetails) : 
            base(name, amount, price, size, colour, weight, material)
        {
            this.Legs = legs;
            this.GloriousDetails = gloriousDetails;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void LoadChairs(List<Product> ChairList)
        {
            ChairList.Add(new Chair("Strandtorp", 15, 579, "52cm*95cm*41cm", "Bergmund svart", 5.6, "Massivträ", 4, false));
            ChairList.Add(new Chair("Strandtorp", 15, 579, "52cm*95cm*41cm", "Tossberg metall svart/grå", 5.6, "Massivträ", 4, false));
            ChairList.Add(new Chair("Lerhamn", 9, 349, "56cm*78cm*47cm", "Svartbrun", 2.3, "Massiv furu", 4, false));
            ChairList.Add(new Chair("Lerhamn", 9, 349, "56cm*78cm*47cm", "Vittaryd beige", 2.3, "Massiv furu", 4, false));
            ChairList.Add(new Chair("Utespelare", 27, 1195, "42cm*128cm*43cm", "Bomstad svart", 12.4, "Skiktlimmat träfaner", 1, true));
            ChairList.Add(new Chair("Utespelare", 27, 1195, "42cm*128cm*43cm", "Bomstad grå", 12.4, "Skiktlimmat träfaner", 1, true));
        }
    }
}
