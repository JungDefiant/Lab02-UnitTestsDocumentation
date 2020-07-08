using System;

namespace UnitTestsDocumentation
{
    class Program
    {

        // ATTR: https://github.com/microsoft/vstest/issues/636

        public static decimal Balance = 5000.00m;

        public static void Main(string[] args)
        {
            DisplayMainMenu();
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine(@"Enter an option from below.
            1) View Balance
            2) Withdraw
            3) Deposit
            4) Exit");

            string input = "";

            while (input == "")
            {
                input = Console.ReadLine();

                if (input == "1")
                {
                    ViewBalance();
                    DisplayContinuePrompt();
                }
                else if (input == "2")
                {
                    Console.WriteLine("How much will you withdraw?");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    Withdraw(withdrawAmount);
                    DisplayContinuePrompt();
                }
                else if (input == "3")
                {
                    Console.WriteLine("How much will you deposit?");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    Deposit(depositAmount);
                    DisplayContinuePrompt();
                }
                else if (input == "4")
                {
                    Console.WriteLine("Thank you for using this ATM! Have a great day!");
                }
                else input = "";
            }
        }

        public static void DisplayContinuePrompt()
        {
            Console.WriteLine("Would you like to make another transaction? Press 1 to continue, any other key to exit.");

            string input = Console.ReadLine();
            if (input == "1") DisplayMainMenu();
            else Console.WriteLine("Thank you for using this ATM! Have a great day!");
        }

        public static void ViewBalance()
        {

        }

        public static void Withdraw(decimal amount)
        {

        }

        public static void Deposit(decimal amount)
        {

        }
    }
}
