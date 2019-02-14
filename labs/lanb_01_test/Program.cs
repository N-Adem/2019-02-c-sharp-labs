using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lanb_01_test
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] hi = { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine(hi[0]);
            var object1 = new Object(); // constructor
            var object2 = new  // object literal
            {
                name= "hi",
                age = 22,
                dob = "21/09/1968"
            };

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(object2);
            }

            byte[] buffer = new byte[4000]; // buffer is used to store raw data. I.e youtyube videos are sent in chunks of data 
            

         }
    }
}
