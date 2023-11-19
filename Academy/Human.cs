using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Human(string last_name, string first_name, int age)
        {
            LastName=last_name;
            FirstName=first_name;
            Age=age;
            Console.WriteLine("HCtor: " + GetHashCode());
        }
        ~Human()
        {
            Console.WriteLine("HDistr: " + GetHashCode());
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Age} лет\t";
        }
    }
}
