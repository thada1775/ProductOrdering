using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using ProductOrdering.Extensions;
using ProductOrdering.Models;
using Rotativa.AspNetCore;
using X.PagedList;

namespace ProductOrdering.Controllers
{
    [Authorize]
    public class OrderingController : Controller
    {

        private readonly ApplicationDbContext _context;
        public OrderingController(ApplicationDbContext context)
        {
            _context = context;
        }
        //public async Task<IActionResult> Index(string? q, int? CategoryId, DateTime dateOrder)
        //{
        //    var orderingSelect = await SearchOrdering(q, CategoryId, dateOrder);
        //    var currentUserId = User.GetLoggedInUserId<String>();
        //    orderingSelect = orderingSelect.Where(o => o.UserId == currentUserId).ToList();
        //    return View(orderingSelect);
        //}
        public async Task<IActionResult> Index(int? page, string? q, int? CategoryId, DateTime dateOrder)
        {
            var allCategory = await _context.Categories.ToListAsync();
            DateTime defaultDatetime = new DateTime(1, 1, 0001);
            ViewBag.q = q;  //set current search to view
            if (dateOrder != new DateTime(1, 1, 0001)) ViewBag.dateOrder = dateOrder.ToString("yyyy-MM-dd"); //set current search to view
            if (ViewBag.CategorySelect == null) ViewBag.CategoryId = new SelectList(allCategory, "CategoryId", "Name");
            else ViewBag.CategoryId = new SelectList(allCategory, "CategoryId", "Name", CategoryId);    //set current search to view

            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int pageSize = 2; // Get total students for each requested page.
            
            var orderingSelect = await SearchOrdering(q, CategoryId, dateOrder);
            var currentUserId = User.GetLoggedInUserId<String>();
            var orderpage = await orderingSelect.Where(o => o.UserId == currentUserId).ToList().ToPagedListAsync(pageNumber,pageSize);
            return View(orderpage);
        }

        [HttpPost]
        public async Task<List<Ordering>> SearchOrdering(string? q,int? CategotyId, DateTime dateOrder)
        {
            DateTime defaultDatetime = new DateTime(1, 1, 0001);    //set datetime if dateorder equals to null
            List<Ordering> orderingSelect;
            if (q != null && CategotyId != null && !DateTime.Equals(dateOrder, defaultDatetime))
            {
                orderingSelect = await _context.Orderings
                .Include(o => o.Product)
                .Include(o => o.Receiver)
                .Where(o => o.Receiver.Name.Contains(q) && o.Product.CategoryId == CategotyId && o.Time.Date == dateOrder.Date)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .ToListAsync();
            }
            else if(q != null && CategotyId == null && DateTime.Equals(dateOrder, defaultDatetime))
            {
                orderingSelect = await _context.Orderings
                    .Include(o => o.Receiver)
                    .Where(o => o.Receiver.Name.Contains(q))
                    .Include(o => o.Product)
                    .Include(o => o.Receiver.District)
                    .Include(o => o.Receiver.Aumphure)
                    .Include(o => o.Receiver.Province)
                    .ToListAsync();
            }
            else if (q == null && CategotyId != null && DateTime.Equals(dateOrder, defaultDatetime))
            {
                orderingSelect = await _context.Orderings
                .Include(o => o.Product)
                .Where(o => o.Product.CategoryId == CategotyId)
                .Include(o => o.Receiver)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .ToListAsync();
            }
            else if (q == null && CategotyId == null && !DateTime.Equals(dateOrder, defaultDatetime))
            {
                orderingSelect = await _context.Orderings
                .Include(o => o.Product)
                .Where(o => o.Time.Date == dateOrder.Date)
                .Include(o => o.Receiver)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .ToListAsync();
            }
            else if(q != null && CategotyId != null && DateTime.Equals(dateOrder, defaultDatetime))
            {
                orderingSelect = await _context.Orderings
                .Include(o => o.Product)
                .Include(o => o.Receiver)
                .Where(o => o.Receiver.Name.Contains(q) && o.Product.CategoryId == CategotyId)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .ToListAsync();
            }
            else if (q == null && CategotyId != null && !DateTime.Equals(dateOrder, defaultDatetime))
            {
                orderingSelect = await _context.Orderings
                .Include(o => o.Product)
                .Include(o => o.Receiver)
                .Where(o => o.Product.CategoryId == CategotyId && o.Time.Date == dateOrder.Date)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .ToListAsync();
            }
            else
            {
                orderingSelect = await _context.Orderings
                .Include(o => o.Product)
                .Include(o => o.Receiver)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .OrderBy(p => p.Time)
                .ToListAsync();
            }
            return orderingSelect;
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
                    if (productSelect.Amount >= model.Amount)       //If amount of product more than stock
                    {
                        var productStock = productSelect.Amount - model.Amount;
                        productSelect.Amount = productStock;
                        model.TotalPrice = model.Amount * productSelect.Price;    //calculate total price

                        _context.Products.Update(productSelect);
                        await _context.Orderings.AddAsync(model);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Index");
                    }
                    ModelState.AddModelError("Error", "จำนวนสินค้าคงเหลือไม่เพียงพอ");       //If amount of product less than stock
                }
                else
                {
                    return NotFound();
                }
            }
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th", model.Receiver.Province_id);

            var allAumphures = await _context.Aumphures.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Aumphure_id = new SelectList(allAumphures, "Id", "Name_th", model.Receiver.Aumphure_id);

            var allDistricts = await _context.Districts.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.District_id = new SelectList(allDistricts, "Id", "Name_th", model.Receiver.District_id);
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

        public async Task<IActionResult> PrintOrder(IFormCollection orderSelect)
        {
            List<Ordering> orderToPrint = new List<Ordering>();

            foreach (var item in orderSelect["OrderingId"])
            {
                int orderingId = Int32.Parse(item);
                var myOrdering = await _context.Orderings.Where(o => o.OrderingId == orderingId)
                .Include(o => o.Product)
                .Include(o => o.Receiver)
                .Include(o => o.Receiver.District)
                .Include(o => o.Receiver.Aumphure)
                .Include(o => o.Receiver.Province)
                .OrderBy(p => p.Time).FirstOrDefaultAsync();
                myOrdering.Status = Status.CompleteSending;     //Set Status Ordering to Complete sending
                _context.Orderings.Update(myOrdering);
                await _context.SaveChangesAsync();

                orderToPrint.Add(myOrdering);
            }

            var DocumentOrder = new ViewAsPdf("OrderPrint", orderToPrint)
            {
                PageSize = Rotativa.AspNetCore.Options.Size.A4,
                FileName = DateTime.Now.ToString("MMddyyyy_HHmmss") + ".pdf"
            };

            return DocumentOrder;
            //return new ViewAsPdf("OrderPrint", orderToPrint);
            //return View("OrderPrint", orderToPrint);
        }

        //public async Task<IActionResult> PrintOrder(IFormCollection orderSelect)
        //{
        //    var orderToPrint = await _context.Orderings
        //        .Include(o => o.Product)
        //        .Include(o => o.Receiver)
        //        .Include(o => o.Receiver.District)
        //        .Include(o => o.Receiver.Aumphure)
        //        .Include(o => o.Receiver.Province).ToListAsync();
        //    var DocumentOrder = new ViewAsPdf("OrderPrint", orderToPrint)
        //    {
        //        PageSize = Rotativa.AspNetCore.Options.Size.A4,
        //        FileName = DateTime.Now.ToString("MMddyyyy_HHmmss") + ".pdf"
        //    };

        //    return DocumentOrder;
        //}

        public async Task<IActionResult> OrderPreparingToPrint(string? q,int? CategoryId, DateTime dateOrder)
        {
            var allCategory = await _context.Categories.ToListAsync();
            ViewBag.CategoryId = new SelectList(allCategory, "CategoryId", "Name");
            var allOrdering = await SearchOrdering(q, CategoryId, dateOrder);
            allOrdering = allOrdering.Where(o => o.Status == Status.Sending).ToList();
            return View(allOrdering);
        }
    }
}