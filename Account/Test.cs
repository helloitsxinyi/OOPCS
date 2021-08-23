using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
   class Test1
   {
      public static void Main()
      {
            // part I
            // Test class Account by creating an Account object
            // and call methods to make sure your code at 
            // class Account work


            // TODO. Create object
            // 1. Create a new Account object account1
            // - accNumber: S0000111
            // - acctHolderId: S1111111A
            // - balance: 2000
            // 2. Call Console.WriteLine(account1)
            // Make sure that the account information 
            // is displayed correctly
            Account account1 = new Account("Acct123", "S1111111A", 2000);        
            Console.WriteLine(account1);



            // TODO: Deposit
            // Deposit 200 to the acccount.
            // Display the account information again and 
            // manually verify the new balance
            account1.Deposit(200);
            Console.WriteLine("Updated balance: " + account1.Balance);



            // TODO: Widthdraw
            // Withdraw 200 from the account.
            // Display the account information again and
            // manually verify the new balance
            account1.Withdraw(200);
            Console.WriteLine("Updated balance: " + account1.Balance);


            // TODO: Widthdraw
            // Withdraw 4000 from the account.
            // Make sure that the withdrawing is unsuccessful.
            account1.Withdraw(4000);
            Console.WriteLine(account1.Balance);

            Account account2 = new Account("123", "456", 100);
            account1.TransferTo(200, account2);
            Console.WriteLine("account1 balance: " + account1.Balance);
            Console.WriteLine("account2 balance: " + account2.Balance);

            // part II
            SavingsAccount savingAccount = new SavingsAccount("Savings123", "S1111111A", 2000);
            Console.WriteLine(savingAccount);
            Console.WriteLine("Interest: {0}", savingAccount.CalculateInterest());
            savingAccount.CreditInterest();
            Console.WriteLine(savingAccount);
            savingAccount.Withdraw(3000);
            savingAccount.TransferTo(3000, account2);
            Console.WriteLine("savingAccount balance: " + savingAccount.Balance);
            Console.WriteLine("account2 balance: " + account2.Balance);

            OverdraftAccount overdraftAccount = new OverdraftAccount("Overdraft123", "S1111111A", 2000);
            Console.WriteLine(overdraftAccount);
            Console.WriteLine("Interest: {0}", overdraftAccount.CalculateInterest());
            overdraftAccount.CreditInterest();
            Console.WriteLine(overdraftAccount);
            overdraftAccount.Withdraw(3000);
            Console.WriteLine("overdraftAccount balance after withdrawal: " + overdraftAccount.Balance);
            overdraftAccount.TransferTo(3000, account2);
            Console.WriteLine("overdraftAccount balance: " + overdraftAccount.Balance);
            Console.WriteLine("account2 balance: " + account2.Balance);
            Console.WriteLine("Interest: {0}", overdraftAccount.CalculateInterest());
            overdraftAccount.CreditInterest();
            Console.WriteLine(overdraftAccount);



        }

    }
}
