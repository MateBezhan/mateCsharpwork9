using System;
using System.Collections.Generic;
using System.Text;

namespace mateCsharpwork9
{
    internal class DepositAccount : CardAccount
    {
        public DepositAccount(string accountNumber, decimal balance, string cardNumber, DateTime cardExpirationDate)
       : base(accountNumber, balance, cardNumber, cardExpirationDate)
        {
        }
    }
}
