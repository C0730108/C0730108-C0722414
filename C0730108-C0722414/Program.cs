using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730108_C0722414
{
    class Program
    {

    }
        
            public class BankAccount
        {
            private string m_customerName;

            private double m_balance;
            private bool m_frozon = false;
            private BankAccount()
            {
            }
            public BankAccount(string customerName,double balance)
            {
                m_customerName = customerName;
                m_balance = balance;

            }
            public string CustomerName
            {
                get { return m_customerName; }
            }
            public double Balance
            {
                get
                {
                    return m_balance;
                }
            }
            public void Debit(double amount)
            {
                if (m_frozon)
                {
                    throw new Exception("Account frozon");

                }
                if (amount > m_balance)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }
                m_balance += amount;
            }
        public void Credit(double amount)
        {
            if (m_frozon)
            {
                throw new Exception("Account frozon");

            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }  
            m_balance += amount;
        }
                private void FreezeAccount()
                {
                    m_frozon = true;

                }
                private void UnFreezeAccount()
                {
                    m_frozon = false;
                }
                public static void Main()
                {
                    BankAccount ba = new BankAccount("Mr.Bryan Walton", 11.99);
                    ba.Credit(5.77);
                    ba.Debit(11.99);
                    Console.WriteLine("Current balance is ${0}", ba.Balance);
                }
            }
  }
        
    

