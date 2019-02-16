using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Random_name_gen_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent.GenPeopleInfo();
        }
    }
    class Parent
    {
        public static void GenPeopleInfo()
        {
            string[] names = { "john", "jess", "christina", "axel", "ruby",
                "striker", "emma", "mo", "annie", "jeff"};
            Random randNum = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                int num = randNum.Next(10);
                int age = randNum.Next(1,100);
                int date = randNum.Next(1,31);
                int month = randNum.Next(1,12);
                int year = randNum.Next(1930, 2019);
           
                DateTime Birthdate = new DateTime(year, month, date,0,0,0);
                Console.WriteLine($"Name is : {names[num]} and age is = {age} and year born {Birthdate}");
            }
        
        }
    }
}
