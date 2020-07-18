using System;

namespace UnitTestsDocumentation
{
    public class Program
    {

        // ATTR: https://github.com/microsoft/vstest/issues/636

        public static decimal Balance = 5000.00m;

        public static void Main(string[] args)
        {
            DisplayMainMenu();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void DisplayMainMenu()
        {
            bool usingATM = true;
            string input = "";

            while (usingATM)
            {
                Console.WriteLine(@"Enter an option from below.
                1) View Balance
                2) Withdraw
                3) Deposit
                4) Exit");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine($"Your current balance is {ViewBalance()}");
                    usingATM = DisplayContinuePrompt();
                }
                else if (input == "2")
                {
                    Console.WriteLine("How much will you withdraw?");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"You withdrew { Withdraw(withdrawAmount) } from your account");
                    Console.WriteLine($"Your current balance is {ViewBalance()}");
                    usingATM = DisplayContinuePrompt();
                }
                else if (input == "3")
                {
                    Console.WriteLine("How much will you deposit?");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"You deposited { Deposit(depositAmount) } into your account");
                    Console.WriteLine($"Your current balance is {ViewBalance()}");
                    usingATM = DisplayContinuePrompt();
                }
                else if (input == "4")
                {
                    usingATM = false;
                }
            }

            Console.WriteLine("Thank you for using this ATM! Have a great day!");
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool DisplayContinuePrompt()
        {
            Console.WriteLine("Would you like to make another transaction? Press 1 to continue, any other key to exit.");

            string input = Console.ReadLine();
            if (input == "1") return true;
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static decimal ViewBalance()
        {
            return Balance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount < 0 || amount > Balance) throw new Exception();

                Balance -= amount;
                return Balance;
            } 
            catch(Exception)
            {
                return -1;
            }
        }

        public static decimal Deposit(decimal amount)
        {
            try
            {
                if (amount < 0) throw new Exception();

                Balance += amount;
                return Balance;
            }
            catch(Exception)
            {
                return -1;
            }
        }
    }
}
