using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_name_gen_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            Parent p2 = new Parent();
            p1.Age = 32;
            p1.Name = "bert";
            p2.Age = 56;
            p2.Name = "chase";
            Console.WriteLine("first parent = "+ p1.Age + " name is = " + p1.Name);
            Console.WriteLine("second parent = "+ p2.Age + " name is = " + p2.Name);         
        }
    }
    class Parent
    {
        int age;
        string name;
        string[] nameList;
        public  string Name{ get { return name;} set { name = value; } }
        public int Age { get{ return age; } set { age = value; } }      
        public Parent()
        {

        }
      
    }

}
