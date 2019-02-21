using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_oop_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.field = 0;
            var c = new Child();
            c.field = 0;
        }
    }
    interface IDoSomething { }
    public class Parent
    {
        public int field;
    }
    //Inherit from parent and implement an interface. 
    class Child : Parent, IDoSomething { }

    // Sealed : No more children  
   sealed class Grandchild : Child {   }
 
}
