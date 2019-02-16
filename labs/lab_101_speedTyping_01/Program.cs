using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_101_speedTyping_01
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool isReady = false;
            double endValue = 0;
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("\nWould you like to start the typing game  (y/n)\n");
            Console.WriteLine("-----------------------------------------");
            char response = Console.ReadKey().KeyChar;
            if (response == 'y')
            {
                Console.WriteLine("** Begin Game **");
                watch.Start();
                isReady = true;
                while (watch.Elapsed.TotalSeconds < 10)
                {
                    GamePlay.SpeedTypeRand();
                   // Console.WriteLine("game active");
                }
                isReady = false;
            }
            if (isReady == false)
            {
                Console.WriteLine($"**GAMEOVER** \nTotal time taken is = {watch.Elapsed.TotalSeconds.ToString()}");
            }
                Console.Read();
        }
    }//-----|End Of Main Method
    class GamePlay
    {
        static string typed = "";
        static List<string> contain = new List<string>();

        public static void SpeedTypeRand()
        {
            Console.WriteLine("input here please");   
        }
    }//-----| End of GamePlay class

}//-----| End of Namespace  
