using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_02
{
    class Program
    {
        static void Main(string[] args)
        {
            var po1 = new Parent(); // syntatic sugar
            po1.Age = -1;
            dynamic x = 10;
            Console.WriteLine("Age is equal to = " + po1.Age);
            Console.Read();
        }
    }

    class Parent
    {
        private int age; // field
        string y{ get; set; }  // shorthand
        public int Age
        {
            get { return this.age; }
            set { if (age > 0) { this.age = value; } else { Console.WriteLine("Change value to greater than 0"); }  }
        }


    }
    class Child: Parent
    {

    }
}
