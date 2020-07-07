using System;

namespace LAB02
{
    public class Program
    {
        public static decimal Balance = 5000;
        static void Main(string[] args)
        {
            UserInterface();
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to the ATM!");
            int userNumber;
            do
            {
                Console.WriteLine("Choose your next Transaction");
                Console.WriteLine("1 Deposit");
                Console.WriteLine("2 Withdraw");
                Console.WriteLine("3 Check your balance");
                Console.WriteLine("4 Exit");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber == 1)
                {
                    Console.WriteLine("How much would you want to deposit?");
                    string userAnswer = Console.ReadLine();
                    int depositAmount = Convert.ToInt32(userAnswer);
                    Deposit(depositAmount);
                }
                else if (Console.ReadLine(2))
                {
                    Console.WriteLine("How much would you want to withdraw?");
                    string userAnswer = Console.ReadLine();
                    userNumber = balance - Convert.ToInt32(userAnswer);
                    return userNumber;
                }
                else if (Console.ReadLine(3))
                {
                    Console.WriteLine($"Your current balance is {balance}");
                }


            } while (userNumber != 4);
        }
        public static decimal Deposit(int amount)
        {
            Balance += amount;
            return Balance;
        }
        }
    }
