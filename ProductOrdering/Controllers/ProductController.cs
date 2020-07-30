using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using ProductOrdering.Models;
using ProductOrdering.Models.ViewModels;
using X.PagedList;

namespace ProductOrdering.Controllers
{
    [Authorize(Roles ="Administrator")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            webHostEnvironment = hostEnvironment;
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    return View(_context.Products.Include(c => c.Category).ToList());
        //}
        public  IActionResult Index(int? page)//Add page parameter
        {
            var pageNumber = page ?? 1; // if no page is specified, default to the first page (1)
            int pageSize = 2; // Get 25 students for each requested page.
            //var onePageOfStudents = Data.StudentContext.StudentList.ToPagedList(pageNumber, pageSize);
            var oneProduct =  _context.Products.ToPagedList(pageNumber, pageSize);
            return View(oneProduct); // Send 25 students to the page.
        }

        [Authorize(Roles ="Administrator")]
        public async Task<IActionResult> AddProduct()
        {
            var allCategory = await _context.Categories.ToListAsync();
            ViewBag.Categories = new SelectList(allCategory, "CategoryId", "Name");
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AddProduct(ProductViewModel model)
        {
            string uniqueFileName = UploadedFile(model);
            var currentProduct = new Product
            {
                Name = model.Name,
                Amount = model.Amount,
                Price = model.Price,
                CategoryId = model.CategoryId,
                ProductImage = uniqueFileName
            };

            _context.Products.Add(currentProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditProduct(int? id)
        {
            var currentProduct = await _context.Products.FirstOrDefaultAsync(c => c.ProductId == id);
            var currentProductViewModel = new ProductViewModel
            {
                ProductId = currentProduct.ProductId,
                Name = currentProduct.Name,
                Amount = currentProduct.Amount,
                Price = currentProduct.Price,
                CategoryId = currentProduct.CategoryId,
            };
            var allCategory = await _context.Categories.ToListAsync();
            ViewBag.CategoryId = new SelectList(allCategory, "CategoryId", "Name");
            if (currentProduct != null)
            {
                return View(currentProductViewModel);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> EditProduct(int id , [Bind("ProductId,Name,Amount,Price,CategoryId,ProductImage")] ProductViewModel model)
        {
            var currentProduct = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == model.ProductId);
            if(id == model.ProductId)
            {
                if (model.ProductImage != null)
                {
                    string fileName = Path.Combine(webHostEnvironment.WebRootPath, "imageSource\\"+ currentProduct.ProductImage);
                    if ((System.IO.File.Exists(fileName)))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    currentProduct.ProductImage = UploadedFile(model);
                }
                currentProduct.Name = model.Name;
                currentProduct.Amount = model.Amount;
                currentProduct.Price = model.Price;
                currentProduct.CategoryId = model.CategoryId;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var currentProduct = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
            if(currentProduct != null)
            {
                _context.Products.Remove(currentProduct);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        
        [Authorize(Roles = "Administrator")]
        private string UploadedFile(ProductViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProductImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imageSource");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProductImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProductImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public async Task<IActionResult> ProductDetails(int id)
        {
            var currentProduct = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
            return PartialView(currentProduct);
        }
    }
}