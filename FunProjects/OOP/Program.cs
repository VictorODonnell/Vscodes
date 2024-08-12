using System;
using System.Data.Common;

namespace oop 
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int roll1 = 0;
                int roll2 = 0;

                Random numGen = new Random();
                Random numGen2 = new Random();

                Console.WriteLine("Press any key to roll");
                Console.ReadKey();

                roll1 = numGen.Next(1, 7);
                roll2 = numGen.Next(1, 7);

                System.Console.WriteLine("\nYour roll: " + roll1);
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Enemy ai roll: " + roll2);

                if(roll1 < roll2) {
                    Console.WriteLine("You Lose");
                }
                else if (roll1 > roll2) {
                    System.Console.WriteLine("You Win");
                }
                else {
                    Console.WriteLine("Draw");
                } 
                Console.ReadKey();
            }            
        }        
    }
}