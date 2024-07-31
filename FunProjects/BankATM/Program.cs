using System;

namespace BankATM 
{
    class Program
    {
        static void Main(string[] args)
        {
            static string userName;
            Console.WriteLine("Hi there! Would you like to apply for an account with Mission Federal?");
            string response = Console.ReadLine();
            if (response.ToLower() == "yes){
            Beginning();
            }
            Console.ReadKey;
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
        }
        static void ApplyForAccount()
            {
                
                Console.WriteLine("Thanks for joining Mission Federal. What is your name?");
                userName = Console.ReadLine();
                
                Console.WriteLine("Hi " + userName + ", Your access code is 1427. Would you like to put some money into your account?");
                string moneyDownConfirm = Console.ReadLine();
                
                if (moneyDownConfirm == "yes")
                {
                    Console.WriteLine("How much money would you like to put in?");
                    
                    string moneyDown = Console.ReadLine();
                    Console.WriteLine("You put " + moneyDown + " in. Is this correct?");
                    string isThisCorrect = Console.ReadLine();
                    
                    if (isThisCorrect.ToLower() == "yes")
                    {
                        Console.WriteLine("You have " + moneyDown + " in your account");yes
                    }
                    Console.WriteLine("Would you like to pull money from your account?"); 

                } 
                else {
                    Console.WriteLine("Have a nice day!");
                }
            }
    }
}
