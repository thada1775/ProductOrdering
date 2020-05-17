using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using ProductOrdering.Extensions;

namespace ProductOrdering.Controllers
{
    public class OrderingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var currentUserId = User.GetLoggedInUserId<String>();
            var myOrdering = await _context.Orderings.Where(o => o.UserId == currentUserId).ToListAsync();
            return View(myOrdering);
        }
        public async Task<IActionResult> AddOrdering()
        {
            
            return View();
        }
        public async Task<IActionResult> ModalPopUp()
        {
            var allProduct = await _context.Products.Include(p => p.Category).ToListAsync();
            return PartialView(allProduct);
        }
        public async Task<IActionResult> ProductListModal()
        {
            var allProduct = await _context.Products.Include(p => p.Category).ToListAsync();
            return View(allProduct);
        }
        [HttpPost]
        public async Task<IActionResult> FindProductSelect(int? ProductId)
        {
            var productSelect = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == ProductId);
            return Json(productSelect);
        }
    }
}