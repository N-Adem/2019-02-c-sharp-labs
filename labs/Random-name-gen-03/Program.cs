using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_name_gen_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent();
            p1.Name = Parent.GenName();
            p1.Age = Parent.GenAge();
            p1.BDay = Parent.GenBirthDay();
           // Console.WriteLine($"name: {p1.Name}, age: {p1.Age}, B-day is: {p1.BDay} ");
            PeopleList(p1.Name, p1.Age);             
        }
        public static void PeopleList(Object name, Object age)
        {
            string newName = name.ToString();
            string newAge = age.ToString();
            Dictionary<string, string> personList = new Dictionary<string, string>();
            personList.Add(newName, newAge);
           // personList.Add(newName, newAge);
           // Console.WriteLine($"name: {newName} age: {newAge} Output Test: {personList}");          
        }
    }   
    class Parent
    {
        private int age;
        private string name;
        private DateTime birthday;
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public DateTime BDay { get { return birthday; } set { birthday = value; } }

        public static string GenName()
        {
            string newName = "";
            string[] names = { "john", "jess", "christina", "axel", "ruby",
                               "striker", "emma", "mo", "annie", "jeff"};
            Random randNum = new Random();
            for (int i = 0; i < 1; i++)
            {
                int num = randNum.Next(10);
                newName = names[num];
            }
            return newName;
        }
        public static int GenAge()
        {
            Random randNum = new Random();
            int age = randNum.Next(1, 100);
            return age;
        }
        public static DateTime GenBirthDay()
        {
            Random randNum = new Random();
            int date = randNum.Next(1, 31);
            int month = randNum.Next(1, 12);
            int year = randNum.Next(1930, 2019);
            DateTime Birthdate = new DateTime(year, month, date, 0, 0, 0);
            return Birthdate;
        }

    }
}
