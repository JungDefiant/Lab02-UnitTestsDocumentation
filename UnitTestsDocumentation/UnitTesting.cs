using System;
using Xunit;

namespace UnitTestsDocumentation
{
    public class UnitTesting
    {
        /// <summary>
        /// Check if balance returns correctly when withdrawing certain amounts
        /// </summary>
        [Fact]
        public static void CheckCorrectWithdraw()
        {
            Program.Balance = 100.00m;

            Program.Withdraw(50.00m);

            Assert.Equal(50.00m, Program.Balance);
        }

        /// <summary>
        /// Check that user cannot withdraw more than balance
        /// </summary>
        [Fact]
        public static void CheckNoWithdrawMoreThanBalance()
        {
            Program.Balance = 100.00m;

            decimal withdrawReturn = Program.Withdraw(150.00m);

            Assert.Equal(-1, withdrawReturn);
        }

        /// <summary>
        /// Check that user cannot withdraw below 0
        /// </summary>
        [Fact]
        public static void CheckNoWithdrawBelowZero()
        {
            Program.Balance = 100.00m;

            decimal withdrawReturn = Program.Withdraw(-1);

            Assert.Equal(-1, withdrawReturn);
        }

        /// <summary>
        /// Check if balance returns correctly when depositing certain amounts
        /// </summary>
        [Fact]
        public static void CheckCorrectDeposit()
        {
            Program.Balance = 100.00m;

            Program.Deposit(50.00m);

            Assert.Equal(150.00m, Program.Balance);
        }

        /// <summary>
        /// Check if deposit fails if depositing a negative amount
        /// </summary>
        [Fact]
        public static void CheckNoNegativeDeposit()
        {
            Program.Balance = 100.00m;

            decimal depositReturn = Program.Deposit(-1);

            Assert.Equal(-1, depositReturn);
        }
 
        /// <summary>
        /// Check if program returns correct balance
        /// </summary>
        [Fact]
        public static void CheckViewBalance()
        {
            Program.Balance = 100.00m;

            Assert.Equal(100.00m, Program.ViewBalance());
        }

        /// <summary>
        /// Check if program returns correct balance after several transactions
        /// </summary>
        [Fact]
        public static void CheckCorrectBalanceAfterTransactions()
        {
            Program.Balance = 100.00m;
            Program.Withdraw(25.00m);
            Program.Deposit(50.00m);
            Program.Deposit(100.00m);
            Program.Withdraw(25.00m);

            Assert.Equal(200.00m, Program.ViewBalance());
        }
    }
}
