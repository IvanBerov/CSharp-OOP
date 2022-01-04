using BankTest;
using NUnit.Framework;

namespace Bank.Test
{
    [TestFixture]
    public class BankAcountTests
    {
        [Test]
        public void When_AccountInitializedWithPositiveValue_AmountShould_BeChanged()
        {
            decimal amount = 5;

            BankAccount bankAccount = new BankAccount(amount);

            Assert.That(bankAccount.Amount, Is.EqualTo(amount));
        }
    }
}
