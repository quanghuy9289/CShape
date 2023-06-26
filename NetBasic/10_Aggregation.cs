using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetBasic
{
    // Aggregation trong C# la moi quan he trong do 1 lop dinh nghia 1 doi tuong cua lop khac
    // con goi la HAS-A relationship (co 1)
    class Address
    {
        public string addressLine, city, state;

        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }

    class User
    {
        public int id;
        public string name;
        public Address address; // Uer HAS-A Address

        public User(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " - " + name + " - " + address.addressLine + ", " + address.city + ", " + address.state);
        }
    }
}
