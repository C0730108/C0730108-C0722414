using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace C0730108_C0722414
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr.Bryan Walton", beginningBalance);

            //Act
            account.Debit(debitAmount);

            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsLessThenZero_ShouldThrowArgumentOutOfRange()  
        {
            //Arrange
            double begninningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr.Bryan Walton", begninningBalance);
            //Act
            account.Debit(debitAmount);
            //Assert is handled by the ExpertedException attribute on the test method.
        }
    }
}
