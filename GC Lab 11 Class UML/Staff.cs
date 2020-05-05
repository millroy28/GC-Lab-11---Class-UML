using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_11_Class_UML
{
    class Staff : Person
    {
        private string School { set; get; }
        private double Pay { set; get; }

        public Staff() { }
        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {
            this.School = School;
            this.Pay = Pay;
        }

        public override string ToString()
        {
            return "Staff: " + base.ToString() + " School " + School + " Pay: " + Pay;
        }
    }
}
