using System;
using System.Data.Common;

namespace oop 
{
    class Program
    {
        static void Main()
        {
            {
            string choice = Console.ReadLine();

            Console.WriteLine("Enter a for apply, b for balance, and n for new card");
                
            if (choice == "a") {
                apply();
            }
            else if (choice == "b") {
                balance();
            }
            else if (choice == "n") {
                NewCard();
            }
            else {
                error();
            }
            Console.ReadKey();
            }            
        } 
        static void apply() {
            string application = Console.ReadLine();

            System.Console.WriteLine("S for savings and c for checkings");
            System.Console.WriteLine("Thank you for applying! Did you want a checking account or savings account?");
            
            if (application == "c") {
                System.Console.WriteLine("Checkings\n");
            }
            else if (application == "s") {
                System.Console.WriteLine("Savings\n");
            }
        }
        static void balance() {
            
        }
        static void NewCard() {
            System.Console.WriteLine("NewCard\n");
        }
        static void error() {
            System.Console.WriteLine("Try Again\n");
            Main();
        }       
    }
}