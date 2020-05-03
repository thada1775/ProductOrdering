using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using ProductOrdering.Extensions;
using ProductOrdering.Models;

namespace ProductOrdering.Controllers
{
    public class UserManagerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UserManagerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var userId = User.GetLoggedInUserId<string>();
            var myUserDetail = await _context.UserDetails
                .Include(d => d.District)
                .Include(a => a.Aumphure)
                .Include(p => p.Province)
                .FirstOrDefaultAsync(u => u.UserId == userId);
            if (myUserDetail != null)
            {
                return View(myUserDetail);
            }
            return View();
        }
        public async Task<IActionResult> AddUserDetail()
        {
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUserDetail(UserDetail model)
        {
            var userId = User.GetLoggedInUserId<string>();
            model.UserId = userId;
            await _context.UserDetails.AddAsync(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<ActionResult> FindAumphor(int? Province_id)
        {
            var prepareAllAumphure = await _context.Aumphures.Where(p => p.Province_id == Province_id).ToListAsync();
            var allAumphure = new SelectList(prepareAllAumphure, "Id", "Name_th",0);
            return Json(allAumphure);
        }
        [HttpPost]
        public async Task<ActionResult> FindDistrict(int? Aumphure_id)
        {
            var prepareAllDistrict = await _context.Districts.Where(p => p.Aumphure_id == Aumphure_id).ToListAsync();
            var allDistrict = new SelectList(prepareAllDistrict, "Id", "Name_th", 0);
            return Json(allDistrict);
        }
    }
}