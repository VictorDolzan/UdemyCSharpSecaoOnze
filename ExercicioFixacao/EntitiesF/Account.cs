using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoOnze.ExercicioFixacao.EntitiesF.Exceptions;

namespace CSharpSecaoOnze.ExercicioFixacao.EntitiesF
{
    class Account
    {
        public int AccNumber { get; private set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {            
        }
        public Account(int externalAccNumber, string externalHolderName, double externalBalance, double externalWithdrawLimit)
        {
            if(externalBalance <= 0)
            {
                throw new AccountException("Please deposit an amount in order to open the account!");
            }
            AccNumber = externalAccNumber;
            HolderName = externalHolderName;
            Balance = externalBalance;
            WithdrawLimit = externalWithdrawLimit;
        }
        public void Deposit(double externalAmount)
        {
            Balance += externalAmount;
        }
        public void Withdraw(double externalAmount)
        {
            if(Balance < 0)
            {
                throw new AccountException("Not enough amount: ");
            }
            if(externalAmount > WithdrawLimit)
            {
                throw new AccountException("The amount exceeds withdraw limit!");
            }
            if(Balance < externalAmount)
            {
                throw new AccountException("Not enough balance!");
            }
            Balance -= externalAmount;
        }
    }
}