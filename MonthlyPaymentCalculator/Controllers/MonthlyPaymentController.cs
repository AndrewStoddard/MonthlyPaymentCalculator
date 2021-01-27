using Microsoft.AspNetCore.Mvc;
using MonthlyPaymentCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonthlyPaymentCalculator.Controllers
{
    public class MonthlyPaymentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.MonthlyPayment = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(MonthlyPayment monthlyPayment)
        {
            if (ModelState.IsValid)
            {
                ViewBag.MonthlyPayment = monthlyPayment.MonthlyPaymentAmount.ToString("c2");
            } else
            {
                ViewBag.MonthlyPayment = "";
            }
            return View();
        }
    }
}
