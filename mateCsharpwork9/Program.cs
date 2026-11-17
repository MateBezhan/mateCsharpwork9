namespace mateCsharpwork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount current = new CurrentAccount("1234567890123456789012", 500.50m, 1000m);
            DepositAccount deposit = new DepositAccount("1234567890123456789013", 2000m, "1234567812345678", new DateTime(2028, 12, 1));
            CreditAccount credit = new CreditAccount("1234567890123456789014", 300m, "8765432187654321", new DateTime(2029, 5, 1));

            Console.WriteLine("Current: " + current.AccountNumber + ", balance " + current.Balance + ", overdraft " + current.OverdraftLimit);
            Console.WriteLine("Deposit: " + deposit.AccountNumber + ", card " + deposit.CardNumber + ", expires " + deposit.CardExpirationDate.ToShortDateString());
            Console.WriteLine("Credit: " + credit.AccountNumber + ", card " + credit.CardNumber + ", expires " + credit.CardExpirationDate.ToShortDateString());

            // Validation test
            try
            {
                current.OverdraftLimit = -50;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
