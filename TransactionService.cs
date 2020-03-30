using System;
using System.Collections.Generic;
using System.Text;


namespace BankAppUpc
{
 
    
    public class TransactionService

    {
       
        public void MakeDeposit(decimal amount, DateTime date, string note, BankAccount account)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amoun of deposit must be positive");

            }
            var deposit = new Transaction(amount, date, note);
         account.transactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note, BankAccount account)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (account.Balance- amount < 0)
            {
                throw new InvalidOperationException("Not sufficent funds for the withdrawal");
            }
            var wirhdrawal = new Transaction(-amount, date, note);
            account.transactions.Add(wirhdrawal);

        }
    }
}
