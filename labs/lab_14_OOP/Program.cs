using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            House h01 = new House(); // objects
            Blueprint b01 = new Blueprint();// objects
            h01.Length = 9; // assigning value

        }
    }
    class Blueprint
    {
        public string field01;
        public string field02;
    }

    class House
    {
        public int numFloors;
        public int numWindows;
        public double Length { get; set; }
    }
}
