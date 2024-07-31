using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BankATM 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there! Would you like to apply for an account with Mission Federal?");
           Beginning();
        }
        
        static void Beginning()
            {
            string apply = Console.ReadLine();

            switch (apply)
            {
                case "yes":
                ApplyForAccount();
                break;
            }
            static void ApplyForAccount()
            {
                
                Console.WriteLine("Thanks for joining Mission Federal. What is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("Hi " + userName + ", Your access code is 1427. Would you like to put some money into your account?");
                string moneyDown = Console.ReadLine();
                
                if (moneyDown == "yes")
                {
                    Console.WriteLine("How much money would you like to put in?");
                    
                    string money = Console.ReadLine();
                    Console.WriteLine("You put " + money + " in. Is this correct?");
                    string isThisCorrect = Console.ReadLine();
                    
                    if (isThisCorrect.ToLower() == "yes")
                    {
                        Console.WriteLine("You have " + money + " in your account");
                    }
                    Console.WriteLine("Would you like to pull money from your account?"); 

                } 
                else {
                    Console.WriteLine("Have a nice day!");
                }
            }
            Console.ReadKey();
        }
    }
}
