using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{

   public class Account
   {
        /**
         * TODO: create attributes
         * This class has 3 attributes:
         * acctNumber : string, private
         * acctHolderId : string, private
         * balance: double, private
         */
        private string acctNumber;
        private string acctHolderId;
        private double balance;

        public Account() { }


        /**
         * TODO: create constructor
         * This contructor receives 3 values
         * and initializes the 3 attributes accordingly
         */
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            AcctNumber = acctNumber;
            AcctHolderId = acctHolderId;
            Balance = balance;
        }


        /**
         * TODO: create properties
         * These properties expose the private attributes
         *
         * Note: acctNumber should be read-only, i.e. can not be
         * set from outside
         */
        protected string AcctNumber { get; }
        protected string AcctHolderId { get; set; }
        public double Balance { get; set; }
        //{
        //    get { return balance; }

        //    set
        //    {
        //        if (value <= 0)
        //        {
        //            Console.WriteLine("Transaction invalid!");
        //            return;
        //        }
        //        balance = value;
        //    }
        //}



        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */

        // don't have to use return. if use, can make loop simpler, otherwise, should be fine.
        public void Deposit(double amt)
        {
            Balance += amt;           
        }



        /**
         * TODO: implement method Withdraw
         * This method decreases the account balance
         * by the given amount. Balance must NOT be negative.
         * It makes sure that there is enough balance to
         * widthdraw
         */

        // don't have to use return. if use, can make loop simpler, otherwise, should be fine.
        public virtual bool Withdraw(double amt)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Invalid withdrawal value, please try again.");
                return false;
            }

            Balance -= amt;
            return true;                  
        }



      /**
       * TODO: implement method TransferTo
       * This method transfers a given amount to another given 
       * account. It makes sure that this sender has enough
       * balance before transfering
       */
      public bool TransferTo(double amt, Account another)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Invalid withdrawal value, please try again.");
                return false;
            }

            if (Withdraw(amt))
            {
                another.Balance += amt;
                return true;
            }

            Console.WriteLine("Insufficient balance in account!");
            return false;
        }


        public virtual double CalculateInterest()
        {
            return 0;
        }


        public virtual void CreditInterest()
        {
            Deposit(CalculateInterest());
        }


        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         */

        // include override keyword to override the function
        //Member modifier 'keyword' must precede the member type and name
        public override string ToString()
        {
            return "accountNumber=" + AcctNumber + ", accountHolder=" + AcctHolderId + ", balance=" + Balance;
        }        
    }
}
