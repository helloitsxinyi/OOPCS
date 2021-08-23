using System;
namespace Account
{
    public class SavingsAccount : Account
    {       
    /**
    * This class should derive from class Account.
    * Savings Account earns 1% interest, but balance can not be negative
    */

        /**
         * TODO: attributes
         * Create static variable interest = 1
         */
        private double interest = 1;



        /**
         * TODO: create a constructor that accepts 3
         * parametes. The constructor should make use
         * of its parent's constructor to initialize
         * its attributes
         */
        public SavingsAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance)
        {
            // ok to be empty here
        }



        /**
         * TODO: implement method CalculateInterest
         * The method return the interest of this account.
         * Savings Account earns 1% interest of its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */




        /**
         * TODO: implement method CreditInterest
         * The method deposit the interst amount, returns by
         * CalculateInterest() method of this
         * account to its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */




        /**
         * TODO: override method Widthraw
         * This method decreases the account balance
         * by the given amount. 
         * For a Savings Account, balance cannot be negative
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */




        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * (SavingsAccout) Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         * 
         * This method should make use of its parent's method
         */




    }

}
