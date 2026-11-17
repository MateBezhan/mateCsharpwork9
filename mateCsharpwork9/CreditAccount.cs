using System;
using System.Collections.Generic;
using System.Text;

namespace mateCsharpwork9
{
    internal class CreditAccount : CardAccount
    {
        public CreditAccount(string accountNumber, decimal balance, string cardNumber, DateTime cardExpirationDate)
    : base(accountNumber, balance, cardNumber, cardExpirationDate)
        {
        }
    }
}
