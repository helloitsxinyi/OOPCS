using System;
namespace CommissionEmployee
{
    // inherit CommissionEmployee class.
    // inherit variables and methods

    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        private double salary;

        // constructors of a base class are not inherited. need to make your own. use BASE keyword.
        // must include arguments in constructor for base class
        // ask parent to initialization for me using base(name, identityNumber....)
        public BasePlusCommissionEmployee(string name, string identityNumber, double grossSales, double commissionRate, double salary): base(name, identityNumber, grossSales, commissionRate)
        {

            // salary only for the BasePlusCommission class
            this.salary = salary;
        }

        public double Earnings()
        {
            return salary + GrossSales * CommissionRate;
        }
    }
}
