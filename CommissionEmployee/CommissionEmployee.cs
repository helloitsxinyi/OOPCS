using System;
namespace CommissionEmployee
{
    public class CommissionEmployee
    {
        private string name;
        private string identityNumber;
        private double grossSales;
        private double commissionRate;

        // best to declare private variables and then provide protected property
        protected double GrossSales
        {
            get { return grossSales; }
            set { grossSales = value; }
        }

        protected double CommissionRate
        {
            get { return commissionRate; }
            set { commissionRate = value; }
        }

        public CommissionEmployee(string name, string identityNumber, double grossSales, double commissionRate)
        {
            this.name = name;
            this.identityNumber = identityNumber;
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }


        public double Earnings()
        {
            return commissionRate * grossSales;
        }
    }
}
