using System;
using System;

namespace BankATM 
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int firstNumber;
                int secondNumber;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Hello! Welcome to the calculator program");
                Console.ForegroundColor = ConsoleColor.White;
                
                Console.WriteLine("Please enter your first number: ");
                firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter your second number: ");   
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your number is " + firstNumber + secondNumber);


                Console.ReadKey();
            }            
        }        
    }
}