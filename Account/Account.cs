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
            this.balance = balance;         
      }


      /**
       * TODO: create properties
       * These properties expose the private attributes
       *
       * Note: acctNumber should be read-only, i.e. can not be
       * set from outside
       */
      public string AcctNumber { get; }
      public string AcctHolderId { get; set; }
      //public double Balance { get; set; }


        public double Balance
        {
            get { return balance; }
                        
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Transaction invalid!");
                    return ;
                }
                balance = value;
            }
        }
        



        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */
        public double Deposit(double amt)
        {
            // NOT Balance, if Balance += amt will end up not changing the value.
            // we want to change the value of balance.
            if (amt <= 0)
            {
                Console.WriteLine("Invalid deposit value, please try again.");
                return balance;
            }
            Balance += amt;
            return Balance;
        }



      /**
       * TODO: implement method Withdraw
       * This method decreases the account balance
       * by the given amount. Balance must NOT be negative.
       * It makes sure that there is enough balance to
       * widthdraw
       */
      public double Withdraw(double amt)
        {
            if (amt <= 0)
            {
                Console.WriteLine("Invalid withdrawal value, please try again.");
            }

            Balance -= amt;
            return Balance;
        }



      /**
       * TODO: implement method TransferTo
       * This method transfers a given amount to another given 
       * account. It makes sure that this sender has enough
       * balance before transfering
       */
      public void TransferTo(double amt, Account another)
        {

        }



      /**
       * TODO: override method ToString
       * This method returns the values of the attributes
       * of the current object in a more readable format
       * For example: 
       * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
       */




   }
}
