using System;
using System.Collections.Generic;
using System.IO;
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
            var myOrdering = await _context.Orderings.Where(o => o.UserId == currentUserId)
                .Include(o => o.Product)
                .Include(o => o.Receiver)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .OrderBy(p => p.Time).ToListAsync();
            return View(myOrdering);
        }
        [HttpPost]
        public async Task<IActionResult> SearchOrdering(string q)
        {
            if (q != null)
            {
                var orderingSelect = await _context.Orderings
                    .Include(o => o.Receiver)
                    .Where(o => o.Receiver.Name.Contains(q))
                    .Include(o => o.Product)
                    .Include(o => o.Receiver.District)
                    .Include(o => o.Receiver.Aumphure)
                    .Include(o => o.Receiver.Province)
                    .ToListAsync();
                return View("Index", orderingSelect);
            }
            return View("Index", await _context.Orderings.Include(o => o.Receiver).Include(o => o.Product).ToListAsync());
        }
        public async Task<IActionResult> AddOrdering()
        {
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th");
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddOrdering(int receiverId)
        {
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th");
            if (receiverId != 0)
            {
                var allAumphure = await _context.Aumphures.OrderBy(p => p.Name_th).ToListAsync();
                ViewBag.Aumphure_id = new SelectList(allAumphure, "Id", "Name_th");
                var allDistrict = await _context.Districts.OrderBy(p => p.Name_th).ToListAsync();
                ViewBag.District_id = new SelectList(allDistrict, "Id", "Name_th");
                var receiverSelect = await _context.Receivers.FirstOrDefaultAsync(r => r.ReceiverId == receiverId);
                var currentOrdering = new Ordering();
                currentOrdering.Receiver = receiverSelect;
                return View(currentOrdering);
            }
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrdering(Ordering model)
        {
            if (ModelState.IsValid)
            {
                var currentUserId = User.GetLoggedInUserId<string>();
                model.UserId = currentUserId;
                model.Time = DateTime.Now;
                model.Discount = model.Discount == null ? 0 : model.Discount;

                var productSelect = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == model.ProductId);
                if (productSelect != null)
                {
                    if (productSelect.Amount < model.Amount)
                    {
                        return View();
                    }
                    var productStock = productSelect.Amount - model.Amount;
                    productSelect.Amount = productStock;
                    model.TotalPrice = model.Amount * productSelect.Price;    //calculate total price
                    _context.Products.Update(productSelect);
                }
                else
                {
                    return NotFound();
                }

                await _context.Orderings.AddAsync(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name-th", model.Receiver.Province_id);
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
        [HttpPost]
        public async Task<ActionResult> FindAumphor(int? Province_id)
        {
            var prepareAllAumphure = await _context.Aumphures.Where(p => p.Province_id == Province_id).OrderBy(p => p.Name_th).ToListAsync();
            var allAumphure = new SelectList(prepareAllAumphure, "Id", "Name_th", 0);
            return Json(allAumphure);
        }
        [HttpPost]
        public async Task<ActionResult> FindDistrict(int? Aumphure_id)
        {
            var prepareAllDistrict = await _context.Districts.Where(p => p.Aumphure_id == Aumphure_id).OrderBy(p => p.Name_th).ToListAsync();
            var allDistrict = new SelectList(prepareAllDistrict, "Id", "Name_th", 0);
            return Json(allDistrict);
        }
   
    }
}