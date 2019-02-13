using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_testing
{
    public class Array
    {
        public int CreateArray( int size)
        {
            int[] myArray = new int[size];
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                myArray[i] = (i + 1) * (i + 1);
            }
            for (int i = 0; i < 10; i++)
            {
                sum += myArray[i];
            }
            return sum;


        }
    }
}