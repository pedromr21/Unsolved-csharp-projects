using System;

namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance = _balance + amount;
            }else {
                Console.WriteLine("Deposit is negative, not depositing anything");
            }
        }

        public void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance = _balance - amount;
            }
            else
            {
                Console.WriteLine("You dont have enough funds to withdraw this amount");
            }
        } 
        #endregion
    }
}