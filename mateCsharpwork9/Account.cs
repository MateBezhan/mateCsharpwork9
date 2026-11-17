using System;
using System.Collections.Generic;
using System.Text;

namespace mateCsharpwork9
{
    internal class Account
    {
        private string accountNumber;
        private decimal balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value == null || value.Length != 22)
                {
                    throw new ArgumentException("Account number must be exactly 22 characters long.");
                }
                accountNumber = value;
            }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
