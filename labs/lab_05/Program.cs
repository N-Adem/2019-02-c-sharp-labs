using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
        
            //GameManager.TimerCounter(20);
            GamePlay.AddKey();
        }
    }
    class GameManager
    {
        // Methods ---------
        public static void TimerCounter(int value)
        {
            float timer = (float)value;
            while (timer > 0)
            {
                timer = timer - (float)0.1;
                Console.WriteLine(timer);
                if (timer < 0)
                {
                    Console.WriteLine("gameover");
                    break;
                }
            }
        }
    }
    class GamePlay : GameManager
    {
        // code for letters in a string to an alphabet in an array of chars. 
        static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static char[] alphaLetters = alphabet.ToCharArray();
        // method adds keys entered to an array and checks whether its in the the alphabet array.
        public static void AddKey()
        {
            List<char> letters = new List<char>();
            for (int i = 0; i < 20; i++)
            {
                letters.Add(Console.ReadKey().KeyChar);
           
            }
            Console.WriteLine("current size of the alphabet size is" + letters.ToString());
        }
        public static void CheckLetter()
        {
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(alphaLetters.Length);
            }
        }

    }
}
