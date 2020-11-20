using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdateBalance()
        {
            // Arrange
            double beginningBalance = 100;
            double debitAmount = 30;
            double expected = 70;
            BankAccount account = new BankAccount("Well", beginningBalance );
            // Act
            account.Debit(debitAmount);
            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, "Débito não ocorreu corretamente.");

        }
        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRanger()
        {
            // Arrange
            double beginnigBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Well", beginnigBalance);
            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(()=>account.Debit(debitAmount));
        }

    }
}
