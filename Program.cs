using System;


namespace BankAppUpc
{
   public class Program
    {
       public static void Main(string[] args)
        {
           
            var account = new BankAccount("Sebastian Montes Molina", 1000);
            Console.WriteLine($"Account {account.Number} was create for {account.Owner} with {account.Balance} initial balance$");

            //retiro//
            TransactionService.MakeWithdrawal(500, DateTime.Now, "Rent payment",account);
            Console.WriteLine(account.Balance);


            //depositos//
            TransactionService.MakeDeposit(100, DateTime.Now, "Frined pay me back",account);
            Console.WriteLine(account.Balance);


            try
            {
                var invalidAccount = new BankAccount("Invalid", -55);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }







            var product = new Product

            {
                Id=1,
                Name="Electric Guitar",
                Status=Enums.Status.Disabled
            };
            //if(product.Status==Enums.Status.Disabled|| product.Status==Enums.Status.Pending)//
            if(ValidationHelper.ProductPendingOrDisabled(product.Status))
            {
                Console.WriteLine($"The current product id {product.Status}");
            }
        }
    }
}
