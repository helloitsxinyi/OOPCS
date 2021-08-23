﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
   /**
    * This class should derive from class Account.
    * Current Account earns 0.25% interest, but balance can not be negative
    */
   class CurrentAccount : Account
   {
        /**
         * TODO: attributes
         * Add instance or static attribute when neccessary
         */
        public static double currInterest = 0.25;




      /**
       * TODO: create a constructor that accepts 3
       * parametes. The constructor should make use
       * of its parent's constructor to initialize
       * its attributes
       */
      public CurrentAccount(string acctNumber, string acctHolderId, double balance): base(acctNumber, acctHolderId, balance)
        {

        }


        /**
         * TODO: implement method CalculateInterest
         * The method return the interest of this account.
         * Current Account earns 0.25% interest of its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */
        public override double CalculateInterest()
        {
            return (currInterest / 100) * Balance;
        }


        /**
         * TODO: override method Widthraw
         * This method decreases the account balance
         * by the given amount. 
         * For a Current Accounts, balance cannot be negative
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */
        public override bool Withdraw(double amt)
        {           
            if (amt > Balance)
            {
                Console.WriteLine("Insufficient balance!");
                return false;
            }
            return base.Withdraw(amt);            
        }




        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * (CurrentAccount) Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         * 
         * This method should make use of its parent's method
         */
        public override string ToString()
        {
            return "(Current Account) " + base.ToString();
        }



    }
}
