using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Parent
    {
        void DoThis() { }
        public virtual void DoThat() { } // virtual is used to override 
    }
    class Child1: Parent
    {
        // can override the parent method (polymorphism) 
        public override void DoThat()
        {
            
        }
    }  class Child2: Parent
    {
        // can override the parent method (polymorphism) 
        public override void DoThat()
        {
            
        }
    }  class Child3: Parent
    {
        // can override the parent method (polymorphism) 
        public override void DoThat()
        {
            
        }
    }
}
