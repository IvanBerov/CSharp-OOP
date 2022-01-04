namespace BankTest
{
    using System;

    public class BankAccount
    {
        private decimal amount = 0;

        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount
        {
            get { return amount;}
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No negatives");
                }

                amount = value;
            }
        }
    }
}
