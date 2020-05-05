using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_11_Class_UML
{
    class Student : Person
    {
        //Parameters
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }
               

            //Constructors
        //Default
        public Student() { }

        //With stuff
        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Fee = Fee;
        }

        //Overridden tostring
        public override string ToString()
        {
            return "Student " + base.ToString() + " Program: " + Program + " Year: " + Year + " Fee: " + Fee;
        }


    }
}
