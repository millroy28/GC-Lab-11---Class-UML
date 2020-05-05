using System;
using System.Collections.Generic;

namespace GC_Lab_11_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> directory = new List<Person>();
            directory.Add(new Staff("Jimmy Mills", "123 Street Lane", "Engineering", 45000));
            directory.Add(new Staff("Rawls Bev", "3567 Lane St", "Buisiness", 39000));
            directory.Add(new Student("Beverly Levity", "67 Wick Ln", "Accounting", 1689, 87600));
            directory.Add(new Student("Jane Winsom", "56 Goat Blvd", "Engineeering", 2061, 97000));
            directory.Add(new Student("Henry Lick", "654 Ransom Ct", "Journalism", 2525, 68000));
            directory.Add(new Person("Vivian Nian", "562 Place St."));

            foreach (Person person in directory)
            {
                Console.WriteLine(person.ToString());
            }
            


        }
    }
}
