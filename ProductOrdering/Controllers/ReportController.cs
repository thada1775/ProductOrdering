using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using ProductOrdering.Data;
using ProductOrdering.Extensions;
using ProductOrdering.Models;
using ProductOrdering.Models.Charts;
using ProductOrdering.Models.ViewModels;

namespace ProductOrdering.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IServiceProvider _serviceProvider;
        private readonly UserManager<ApplicationUser> _usermanager;
        public ReportController(ApplicationDbContext context, IServiceProvider serviceProvider, UserManager<ApplicationUser> usermanager)
        {
            _serviceProvider = serviceProvider;
            _usermanager = usermanager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var roleManager = _serviceProvider.GetService<IdentityRole>();
            var userManager = _serviceProvider.GetService<ApplicationUser>();
            var allUser = await _context.Users.Include(u => u.UserDetail)
                .Include(u => u.UserDetail.District)
                .Include(u => u.UserDetail.Aumphure)
                .Include(u => u.UserDetail.Province)
                .ToListAsync();

            foreach (var user in allUser)
            {
                user.Roles = (List<string>)await _usermanager.GetRolesAsync(user);
            }
            return View(allUser);
        }

        [HttpGet]
        public async Task<IActionResult> ViewReportEachUser(string id, DateTime dateSearch)
        {
            var userId = id;
            DateTime defaultDatetime = new DateTime(1, 1, 0001);

            var userDetail = await _context.UserDetails.Where(u => u.UserId == userId)
                .Include(u => u.District)
                .Include(u => u.Aumphure)
                .Include(u => u.Province)
                .FirstOrDefaultAsync();

            List<Ordering> orderings;
            List<Ordering> orderingCompleteOfUser;
            List<Ordering> orderingCancelOfUser;
            List<Ordering> orderingSendingOfUser;

            ReportViewModel orderingOfUser = new ReportViewModel();
            if (!DateTime.Equals(defaultDatetime, dateSearch))
            {
                var firstDayOfMonth = new DateTime(dateSearch.Year, dateSearch.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                orderings = await _context.Orderings
                 .Where(o => o.UserId == userId && o.Time >= firstDayOfMonth && o.Time <= lastDayOfMonth).Include(o => o.ApplicationUser)
                 .ToListAsync();

                orderingCompleteOfUser = orderings
                    .Where(o => o.Status == Status.CompleteSending)
                    .ToList();
                orderingCancelOfUser = orderings
                    .Where(o => o.Status == Status.CancleOrder)
                    .ToList();
                orderingSendingOfUser = orderings
                    .Where(o => o.Status == Status.Sending)
                    .ToList();

                orderingOfUser.SearchByMonth = true;
                orderingOfUser.DisplayingTime = dateSearch;

                orderingOfUser.orderingsByMonthJson = await GenerateUserSalesForMonth(userId, dateSearch);
            }
            else
            {
                orderings = await _context.Orderings
                 .Where(o => o.UserId == userId).Include(o => o.ApplicationUser)
                 .ToListAsync();

                orderingCompleteOfUser = orderings
                    .Where(o => o.Status == Status.CompleteSending)
                    .ToList();
                orderingCancelOfUser = orderings
                    .Where(o => o.Status == Status.CancleOrder)
                    .ToList();
                orderingSendingOfUser = orderings
                    .Where(o => o.Status == Status.Sending)
                    .ToList();

                orderingOfUser.SearchByMonth = false;       //SearchByYear
                orderingOfUser.DisplayingTime = DateTime.Now;
            }

            orderingOfUser.UserDetail = userDetail;
            orderingOfUser.orderings = orderings;
            orderingOfUser.orderingCompleteOfUser = orderingCompleteOfUser;
            orderingOfUser.orderingSendingOfUser = orderingSendingOfUser;
            orderingOfUser.orderingCancelOfUser = orderingCancelOfUser;

            return View(orderingOfUser);
        }

        [HttpGet]
        public JsonResult GenerateUserSalesOneYearChart(string userId)
        {

            var currentYear = DateTime.Now.Year;
            var orderings = _context.Orderings.Where(o => o.Time.Year == currentYear && o.Status == Status.CompleteSending && o.UserId == userId);
            var userSales = new UserSalesforOneYear().GetUserSalesforOneYearsList();
            foreach (var item in userSales)
            {
                if (item.Month == "Jan")
                {
                    //var date1 = new DateTime(currentYear, 1, 1);
                    //var timeset1 = date1.ToString("yyyyMM");
                    var totalOrdering = orderings.Where(o => o.Time.Month == 1).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Feb")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 2).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Mach")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 3).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Apil")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 4).Count();
                    item.Quantity = totalOrdering;

                }
                else if (item.Month == "May")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 5).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "June")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 6).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "July")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 7).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Aug")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 8).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Seb")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 9).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Oct")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 10).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Nov")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 11).Count();
                    item.Quantity = totalOrdering;
                }
                else if (item.Month == "Dec")
                {
                    var totalOrdering = orderings.Where(o => o.Time.Month == 12).Count();
                    item.Quantity = totalOrdering;
                }
            }
            return Json(userSales);
        }
        [HttpGet]
        public async Task<JsonResult> GenerateUserSalesForMonth(string userId, DateTime searchByMonth)
        {
            var firstDayOfMonth = new DateTime(searchByMonth.Year, searchByMonth.Month, 1);
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            //var lastDayOfMonth = DateTime.DaysInMonth(1980, 08);
            var ordering = await _context.Orderings.Where(o => o.UserId == userId
                && o.Status == Status.CompleteSending
                && o.Time.Date >= firstDayOfMonth && o.Time.Date <= lastDayOfMonth).ToListAsync();

            var userSales = new UserSalesForOneMonth().GetListDayOfMonth(lastDayOfMonth.Day);
            foreach (var item in userSales)
            {
                int resultCount = ordering.Where(o => o.Time.Day == item.NumDay).Count();
                item.Quantity = resultCount;
            }

            return Json(userSales);
        }

    }
}
