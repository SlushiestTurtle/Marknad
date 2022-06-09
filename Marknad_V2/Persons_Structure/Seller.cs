using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marknad_V2.Persons_Structure
{
    public class Seller : Person_Build
    {
        public int employeeId { get; set; }

        public Seller(string name, string address, int phoneNumber, int employeeId) : base(name, address, phoneNumber)
        {
            this.employeeId = employeeId;
        }

        public void Presentation(string name)
        {
            Console.WriteLine($"Hello and welcome to my shop!\nMy name is {name}. Suit yourself and check my shop.");
        }

        public void TellThePrice(string name, double price)
        {
            Console.WriteLine($"The {name} cost {price}.");
        }

        public void LoadSeller(List<Seller> seller)
        {
            seller.Add(new Seller("Johan", "Storgatan 13, 70361 Örebro", 0715154455, 12));
            seller.Add(new Seller("Sussan", "Sjögatan 16, 85230 Sundsvall", 0796587452, 736));
        }
    }
}
