using System;

namespace LAB02
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface();
            Console.WriteLine("Hello World!");
        }

        static void UserInterface()
        {
            int balance = 5000;
            while(transaction)
            {
                Console.WriteLine("Choose your next Transaction");
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdraw");
                Console.WriteLine("Check your balance");
                Console.WriteLine("Exit");
                if (Console.ReadLine(1))
                {
                    Console.WriteLine("How much would you want to deposit?");
                    string userAnswer = Console.ReadLine() + balance;
                    int userNumber = Convert.ToInt32(userAnswer);
                    Console.WriteLine("Are you sure?");
                    if (y == true)
                    {
                        return userNumber;
                    }
                    else if(n == true)
                    {
                        UserInterface();
                    }
                }
                else if (Console.ReadLine(2))
                {
                    Console.WriteLine("How much would you want to withdraw?");
                    string userAnswer = Console.ReadLine();
                    int userNumber = balance - Convert.ToInt32(userAnswer);
                    return userNumber;
                }
                else if (Console.ReadLine(3))
                {
                    Console.WriteLine($"Your current balance is {balance}")
                }
            }
        }
    }
}
