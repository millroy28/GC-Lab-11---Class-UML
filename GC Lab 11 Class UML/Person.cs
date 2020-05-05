using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_11_Class_UML
{
    class Person
    {
            //parameters
        private string Name { get; set; }
        private string Address { get; set; }

            //Constructor
        //Default
        public Person() { }

        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return "Name: " + Name + "  Address: " + Address;
        }
    }
}
