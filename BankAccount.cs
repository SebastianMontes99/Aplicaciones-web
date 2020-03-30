using System;
using System.Collections.Generic;
using System.Text;


namespace BankAppUpc
{

    
   public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
     
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in transactions)
                {
                    balance += item.amount;
                }
                return balance;
            }
        }
        public List<Transaction> transactions = new List<Transaction>();


        public static int accountNumbrerSeed= 1234567890;




        //constructor//
        public BankAccount(string name, decimal initialBalance)
        {
    
            this.Number = accountNumbrerSeed.ToString();
            accountNumbrerSeed++;
            this.Owner = name;
      TransactionService.MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
        }

        //hacer un deposito caracteristica //

    }
}
