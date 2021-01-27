// ***********************************************************************
// Assembly         : MonthlyPaymentCalculator
// Author           : Andrew Stoddard
// Created          : 01-27-2021
//
// Last Modified By : Techsa
// Last Modified On : 01-27-2021
// ***********************************************************************
// <copyright file="HomeController.cs" company="MonthlyPaymentCalculator">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using Microsoft.AspNetCore.Mvc;
using MonthlyPaymentCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonthlyPaymentCalculator.Controllers
{
    /// <summary>
    /// Class HomeController.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.Controller" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns>IActionResult.</returns>
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MonthlyPayment = 0.ToString("c2");
            return View();
        }

        /// <summary>
        /// Indexes the specified monthly payment.
        /// </summary>
        /// <param name="monthlyPayment">The monthly payment.</param>
        /// <returns>IActionResult.</returns>
        [HttpPost]
        public IActionResult Index(MonthlyPaymentModel monthlyPayment)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MonthlyPayment = monthlyPayment.MonthlyPaymentAmount().ToString("c2");
            } else
            {
                ViewBag.MonthlyPayment = 0.ToString("c2");
            }
            return View();
        }
    }
}
