using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_113_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class ArrayList1
    {
        public int ArrayListMethod(int a, int b, int c, int d)
        {
            // accept four integers
            /*
             put to array
             extract and double => put to queue 
             extract and double =>  put to stack
             extract and square =>  put to dictionary
             put to array list
             eXTCRACT AND get THE SUM OF  THE ITEMS and return this sum                     
             */
            int[] inputArr = { a,b,c,d};
            Queue<int> queueDouble = new Queue<int>();
            Stack<int> stackDouble = new Stack<int>();
            Dictionary<int,int> dictSquare = new Dictionary<int,int>();
            ArrayList arrList = new ArrayList();
            var sum = 0;
            for (int i = 0; i < 4; i++)
            {
                queueDouble.Enqueue(i * 2);
            }
            foreach (var i in queueDouble)
            {
                stackDouble.Push(queueDouble.Dequeue() * 2);
            }
            foreach (var val in stackDouble)
            {               
                dictSquare.Add(val, stackDouble.Pop() * stackDouble.Pop());
            }
            foreach (var i in dictSquare)
            {
                arrList.Add(i);
            }
            for (int i = 0; i < arrList.Count; i++)
            {                
                sum += i;
            }
            return sum;
        }
    }
}
