using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Parent();
            var p2 = new Parent();
            p1.Name = "Jess";
            p2.Name = "Jack";
            Console.WriteLine(p1.Name + " " +"and" + " " +p2.Name);
        }
    }
    class Parent
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Parent()
        {
    
        }
    }
}
