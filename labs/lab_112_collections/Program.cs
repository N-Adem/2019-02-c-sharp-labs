using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_112_collections
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
      
    }

    public class Collection
    {
        /* Recieve three numbers
         * 
         * put these numbers into an array
         * output the numbers, double each one and store in a stack
         * repeat this ie out put numbers, double and store and store in a queue
         * out put numbers square them and store in a list of int  
         * add up numbers in the list <int> and return total. 
         * 
        */

        public int Collection20MinLab(int num1, int num2, int num3)
        {
            int[] numArray = { num1, num2, num3 };
            Stack<int> stackCollect = new Stack<int>();
            Queue<int> queueCollect = new Queue<int>();
            List<int> listCollect = new List<int>();
      
            Console.Write(numArray);

            foreach (var i in numArray)
            {
                stackCollect.Push(i * 2);
                Console.Write("num in stack = " + stackCollect.Count);
            }
            foreach (var i in stackCollect)
            {
                Console.Write(queueCollect);
                queueCollect.Enqueue(i * 2);
            }
            foreach (var i in queueCollect)
            {
               
                Console.Write(listCollect);
                listCollect.Add(i * i);
            }
            var total = 0;
            foreach (var i in listCollect)
            {
                total += i;
            }
            return total;
        }

    }
}
