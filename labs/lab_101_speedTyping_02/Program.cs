using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace lab_101_speedTyping_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Game flow variables
            bool isRand = false;
            bool isReady = false;
            bool isOrdered = false;
            Stopwatch watch = new Stopwatch();
            // Game Intro 
            Console.WriteLine("Would you like to play the ordered or unordered (1/2)");
            char choice = Console.ReadKey().KeyChar;
            if (choice == '1')
            {
                isRand = true;
                isOrdered = false;
                Console.Write("you picked un ordered\n");
            }
            if (choice == '2')
            {
                isOrdered = true;
                Console.Write("you picked ordered\n");
            }
            Console.WriteLine("\nWould you like to start the typing game  (Y/N)\n");
            Console.WriteLine("-----------------------------------------");
            char response = Console.ReadKey().KeyChar;
            if (response == 'Y')
            {
                Console.WriteLine("** Begin Game **");
                watch.Start();
                isReady = true;
                while (watch.Elapsed.TotalSeconds < 10)
                {
                    if (isRand == true)
                    {
                        GamePlay.SpeedTypeRand();
                    }
                    if (isOrdered == true)
                    {
                        GamePlay.SpeedTypeOrdered();
                    }
                    //Console.WriteLine("game active");
                }
                isReady = false;
            }
            if (isReady == false)
            {
                Console.WriteLine($"**GAMEOVER** \nTotal time taken is = {watch.Elapsed.TotalSeconds.ToString()}");
                if (watch.Elapsed.TotalSeconds >= 11)
                {
                    Console.WriteLine("Took you more than 10 seconds you lose");
                }
                else
                {
                    Console.WriteLine("\nCongratulations you played well");
                }
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
            Console.WriteLine();
            typed += Console.ReadKey().KeyChar;            
        }
        public static void SpeedTypeOrdered()
        {
            string val = "";
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] alphaLetters = alphabet.ToCharArray();
            for (int i = 0; i < alphaLetters.Length; i++)
            {
                val += alphaLetters[i].ToString();
                typed += Console.ReadKey().KeyChar;
            
                if (typed == val)
                {
                    Console.WriteLine(" = you may continue");
                }
                else
                {
                    Console.WriteLine("YOU ENTERED THE WRONG LETTER = " + val);
                    val += alphaLetters[i].ToString();
                }
                //Console.WriteLine(alphaLetters[3]);
            }
        }
    }//-----| End of GamePlay class

}//-----| End of Namespace  
