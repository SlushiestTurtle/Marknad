using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marknad_V2.Persons_Structure
{
    public class Person_Build
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public Person_Build(string name, string address, int phoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }
    }
}
