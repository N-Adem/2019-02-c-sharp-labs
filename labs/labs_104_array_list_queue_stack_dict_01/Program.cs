using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labs_104_array_list_queue_stack_dict_01
{
    class Program
    {

        static List<int> addOneList = new List<int>();
        static Stack<int> addOneStack = new Stack<int>();
        static Queue<int> addQueue = new Queue<int>();
        static Dictionary<int,int> addDictionary = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            //put 10 numbers in an array
            int[] arrNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // ------ move the items to a list then add 1
            foreach (var i in addOneList)
            {
                addOneList.Add(i + 1);
            }
            // ------- Move to a stack then add one 
            foreach (var i in arrNumber)
            {
                addOneStack.Push(i + 1);
                // Console.WriteLine(addOneStack.Count);
            }
            // ------ move to a queue then add one 
            for (int i = 0; i < 10; i++)
            {
                addQueue.Enqueue(addOneStack.Pop() + 1);
            }
            // ----- move to dictionary and add one
            for (int i = 0; i <10; i ++ )
            {
                addDictionary.Add(i, addQueue.Dequeue() + 1);
            }
            // ------- return total. 
            int total = 0;
            foreach (int key in addDictionary.Keys)
            {
                total = total + addDictionary[key];
            }
        }

    }
    class Number
    {
        static List<int> addOneList = new List<int>();
       static  Stack<int> addOneStack = new Stack<int>();
       static  Queue<int> addQueue = new Queue<int>();
        public static void Result()
        {
            int[] arrNumber = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //foreach (var j in addOneList)
            //{
            //    addOneList.Add(i + 1);
            //}
            //foreach (var k in arrNumber)
            //{
            //    addOneStack.Push(i + 1);
            //    // Console.WriteLine(addOneStack.Count);
            //}
            //for (int l = 0; l < 10; l++)
            //{
            //    addQueue.Enqueue(addOneStack.Pop() + 1);
            //}

        }

    }
}
