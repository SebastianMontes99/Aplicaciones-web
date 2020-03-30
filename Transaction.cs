using System;
using System.Collections.Generic;
using System.Text;

namespace BankAppUpc
{
    public class Transaction
    {
        public decimal amount { get;  }
        public DateTime Date { get; }
        public String Notes { get;  }
        public Transaction  (decimal amount, DateTime date,string note )
        {
            this.amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}
