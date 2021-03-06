﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductOrdering.Data;
using ProductOrdering.Models;
using ProductOrdering.Models.ViewModels;

namespace ProductOrdering.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly LineNotify _lineNotify;
        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context,
            LineNotify lineNotify)
        {
            _logger = logger;
            _context = context;
            _lineNotify = lineNotify;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["IsValid"] = await _lineNotify.IsValid();
            var product = await _context.Products.Take(3).ToListAsync();
            return View(product);
        }

        public async Task<IActionResult> Dashboard()
        {
            int AllOrder = _context.Orderings.Count();
            int CompleteOrder = _context.Orderings.Count(o => o.Status == Status.CompleteSending);
            int SendingOrder = _context.Orderings.Count(o => o.Status == Status.Sending);
            int CancelOrder = _context.Orderings.Count(o => o.Status == Status.CancleOrder);

            var allUser = _context.Users.Where(u => u.NormalizedEmail != "THADA1775@GMAIL.COM" && u.EmailConfirmed == true).Include(u => u.UserDetail);

            int[] allmount = new int[]
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            List<int> orderLastYear = new List<int>();
            List<int> orderCurrentYear = new List<int>();

            var CurrentYear = DateTime.Now.Year;
            var lastYear = CurrentYear - 1;
            foreach(var mount in allmount)  //first calculate last year
            {
                var startDateSelect = new DateTime(lastYear, mount, 1);
                var endDateSelect = startDateSelect.AddMonths(1).AddDays(-1);

                int amount = _context.Orderings.Count(o => o.Time.Date >= startDateSelect && o.Time.Date <= endDateSelect);
                orderLastYear.Add(amount);
            }
            foreach (var mount in allmount)  //first calculate last year
            {
                var startDateSelect = new DateTime(CurrentYear, mount, 1);
                var endDateSelect = startDateSelect.AddMonths(1).AddDays(-1);

                int amount = _context.Orderings.Count(o => o.Time.Date >= startDateSelect && o.Time.Date <= endDateSelect);
                orderCurrentYear.Add(amount);
            }
            var infoDashboard = new DashboardViewModel
            {
                AllOrder = AllOrder,
                CompleteOrder = CompleteOrder,
                SendingOrder = SendingOrder,
                CancelOrder = CancelOrder,
                AllUser = allUser,
                OrderLastYear = orderLastYear,
                OrderCurrentYear = orderCurrentYear
            };
                return View(infoDashboard);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LineNotify(string provider)
        {
            return _lineNotify.Authorize();
        }
        
        [HttpGet]
        public async Task<IActionResult> LineNotifyCallback(string remoteError = null)
        {
            if(!string.IsNullOrEmpty(remoteError))
            {
                ModelState.AddModelError(string.Empty, "Error from Line provider");
                return View("Index");
            }
            var callBackRespone = await _lineNotify.Callback();
            if (callBackRespone)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> Index(string message)
        {
            await _lineNotify.SendNotify(message);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Revoke()
        {
            await _lineNotify.Revoke();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
