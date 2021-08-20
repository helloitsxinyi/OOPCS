using System;
namespace CommissionEmployee
{
    public class CommissionEmployee
    {
        protected string name;
        protected string identityNumber;
        protected double grossSales;
        protected double commissionRate;

        public CommissionEmployee(string name, string identityNumber, double grossSales, double commissionRate)
        {
            this.name = name;
            this.identityNumber = identityNumber;
            this.grossSales = grossSales;
            this.commissionRate = commissionRate;
        }


        public double Earnings()
        {
            return commissionRate * grossSales;
        }
    }
}
