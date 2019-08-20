using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Customer
    {
        private string name;
        private string phone;
        private string address;

        public Customer(string name, string phone, string address)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
        }
        public Customer() { }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
