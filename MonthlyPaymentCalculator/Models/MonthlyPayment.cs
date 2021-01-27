using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonthlyPaymentCalculator.Models
{
    public class MonthlyPayment
    {
        public int PurchasePrice { get; set; }
        public double InterestRate { get; set; }
        public int Years { get; set; }
        public double MonthlyPaymentAmount => (InterestRate * PurchasePrice) / (1 - Math.Pow(1 + InterestRate, Years * 12));
    }
}
