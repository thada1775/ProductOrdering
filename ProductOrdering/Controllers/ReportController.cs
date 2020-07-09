using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;

namespace ProductOrdering.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allUser = await _context.Users.Include(u => u.UserDetail).Include(u => u.UserRoles).ToListAsync();
            return View(allUser);
        }
    }
}
