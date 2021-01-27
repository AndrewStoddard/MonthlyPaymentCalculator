using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonthlyPaymentCalculator.Models
{
    public class MonthlyPaymentModel
    {
        [Required(ErrorMessage = "Please enter a purchase price.")]
        [Range(1, Double.MaxValue, ErrorMessage = "Purchase Price must be greater than 0.")]
        public int? PurchasePrice { get; set; }
        [Required(ErrorMessage = "Please enter a interest rate.")]
        [Range(0, 20, ErrorMessage = "Interest rate must be between 0 and 20.")]
        public double? InterestRate { get; set; }
        [Required(ErrorMessage = "Please enter a number of years.")]
        [Range(1, 7, ErrorMessage = "Number of years must be between 1 and 7.")]
        public int? Years { get; set; }
        public double MonthlyPaymentAmount()
        {
            double result = 0.0;
            double r = ((double)(InterestRate / 100));
            double n = (double)(Years * 12);
           
            result = (double)(r * PurchasePrice);
            result = result / (1 - (Math.Pow((1 + r), -n)));

            return result;
        }
    }
}
