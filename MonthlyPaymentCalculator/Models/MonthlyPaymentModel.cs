// ***********************************************************************
// Assembly         : MonthlyPaymentCalculator
// Author           : Andrew Stoddard
// Created          : 01-27-2021
//
// Last Modified By : Techsa
// Last Modified On : 01-27-2021
// ***********************************************************************
// <copyright file="MonthlyPaymentModel.cs" company="MonthlyPaymentCalculator">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MonthlyPaymentCalculator.Models
{
    /// <summary>
    /// Class MonthlyPaymentModel.
    /// </summary>
    public class MonthlyPaymentModel
    {
        /// <summary>
        /// Gets or sets the purchase price.
        /// </summary>
        /// <value>The purchase price.</value>
        [Required(ErrorMessage = "Please enter a purchase price.")]
        [Range(1, Double.MaxValue, ErrorMessage = "Purchase Price must be greater than 0.")]
        public int? PurchasePrice { get; set; }
        /// <summary>
        /// Gets or sets the interest rate.
        /// </summary>
        /// <value>The interest rate.</value>
        [Required(ErrorMessage = "Please enter a interest rate.")]
        [Range(0, 20, ErrorMessage = "Interest rate must be between 0 and 20.")]
        public double? InterestRate { get; set; }
        /// <summary>
        /// Gets or sets the years.
        /// </summary>
        /// <value>The years.</value>
        [Required(ErrorMessage = "Please enter a number of years.")]
        [Range(1, 7, ErrorMessage = "Number of years must be between 1 and 7.")]
        public int? Years { get; set; }
        /// <summary>
        /// Monthlies the payment amount.
        /// </summary>
        /// <returns>System.Double.</returns>
        public double MonthlyPaymentAmount()
        {
            double result = 0.0;
            double r = ((double)(InterestRate / 12 / 100));
            double n = (double)(Years * 12);
           
            result = (double)(r * PurchasePrice);
            result = result / (1 - (Math.Pow((1 + r), -n)));

            return result;
        }
    }
}
