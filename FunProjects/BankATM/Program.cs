using System;

namespace BankATM 
{
    class Program
    {
        static int cBalance;
        static int sBalance;

        static void Main()
        {
            {
            string choice;

            Console.WriteLine("Enter a for apply, b for balance, and n for new card");
            choice = Console.ReadLine();
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
        static string application;  

        static void apply() {
            

            System.Console.WriteLine("C for checkings and b for both");
            System.Console.WriteLine("Thank you for applying! Did you want a checking account and a savings account or just a checkings account?");
            
            application = Console.ReadLine();
            
            if (application == "c") {
                System.Console.WriteLine("Checkings\n");
                System.Console.WriteLine("How much cash did you want to add?");
            }
            else if (application == "b") {
                System.Console.WriteLine("You have a new savings and checking account! \n");
            }


            int insertCash;
            insertCash = Convert.ToInt32(Console.ReadLine());
            cBalance += insertCash;
            System.Console.WriteLine("Your balance is " + (cBalance));
            Main();

        }
        static void balance() {
            if (application == "c") {
                System.Console.WriteLine("Checkings balance\n");
                System.Console.WriteLine("Your Checking balance is: " + cBalance);
            }

            else if (application == "b") {
                System.Console.WriteLine("savings balance \n");
            }
            
            else {
                System.Console.WriteLine("No account was created. Please enter to try again\n");
                Console.ReadKey();
                Main();
            }
        }
        static void NewCard() {
             if (application == "c") {
                System.Console.WriteLine("You got a new card.\n Please enter your new pin");
                int pin = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Your pin is " + pin);
            }

            else if (application == "b") {
                System.Console.WriteLine("You got a new card\n");
            }
            
            else {
                System.Console.WriteLine("No account was created. Please enter to try again\n");
                Console.ReadKey();
                Main();
            }
        }
        static void error() {
            System.Console.WriteLine("Try Again\n");
            Main();
        }       
    }
}