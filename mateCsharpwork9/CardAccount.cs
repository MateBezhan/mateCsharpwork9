using System;
using System.Collections.Generic;
using System.Text;

namespace mateCsharpwork9
{
    internal class CardAccount : Account
    {
        private string cardNumber;

        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 16)
                {
                    throw new ArgumentException("Card number must have a maximum of 16 digits.");
                }

                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        throw new ArgumentException("Card number must contain only digits.");
                    }
                }

                cardNumber = value;
            }
        }

        public DateTime CardExpirationDate { get; set; }

        public CardAccount(string accountNumber, decimal balance, string cardNumber, DateTime cardExpirationDate)
            : base(accountNumber, balance)
        {
            CardNumber = cardNumber;
            CardExpirationDate = cardExpirationDate;
        }
    }
}
