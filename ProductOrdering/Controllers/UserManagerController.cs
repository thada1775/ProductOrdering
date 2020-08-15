using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using ProductOrdering.Extensions;
using ProductOrdering.Models;

namespace ProductOrdering.Controllers
{
    [Authorize]
    public class UserManagerController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public UserManagerController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
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
        public async Task<IActionResult> EditUserDetail(int id)
        {
            var UserDetailSelect = await _context.UserDetails.FirstOrDefaultAsync(u => u.UserDetailId == id);
            if (UserDetailSelect == null)
            {
                return NotFound();
            }
            
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th",UserDetailSelect.Province_id);

            var allAumphure = await _context.Aumphures.Where(a => a.Province_id == UserDetailSelect.Province_id).OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Aumphure_id = new SelectList(allAumphure, "Id", "Name_th", UserDetailSelect.Aumphure_id);

            var allDistrict = await _context.Districts.Where(a => a.Aumphure_id == UserDetailSelect.Aumphure_id).OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.District_id = new SelectList(allDistrict, "Id", "Name_th", UserDetailSelect.District_id);

            return View(UserDetailSelect);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="Administrator")]
        public async Task<IActionResult> EditUserDetail(UserDetail model)
        {
            if (ModelState.IsValid)
            {
#pragma warning disable CS8600
                string UserimageSelect = await _context.UserDetails.Where(ud => ud.UserDetailId == model.UserDetailId).Select(ud => ud.UserImage).FirstOrDefaultAsync();
#pragma warning restore CS8600
                if (model.UserImageForm != null || model.UserImage == null)     //if user upload image mean user change image profile
                {
                    if(!string.IsNullOrEmpty(UserimageSelect))
                    {
                        string filepath = Path.Combine(webHostEnvironment.WebRootPath, "imageSource\\UserImage\\" + UserimageSelect);
                        if (System.IO.File.Exists(filepath))
                        {
                            System.IO.File.Delete(filepath);    //delete old image profile
                        }
                    }          
                    model.UserImage = UploadedFile(model);
                }

                _context.Update(model);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }
            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th", model.Province_id);

            var allAumphure = await _context.Aumphures.Where(a => a.Province_id == model.Province_id).OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Aumphure_id = new SelectList(allAumphure, "Id", "Name_th", model.Aumphure_id);

            var allDistrict = await _context.Districts.Where(a => a.Aumphure_id == model.Aumphure_id).OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.District_id = new SelectList(allDistrict, "Id", "Name_th", model.District_id);

            return View(model);
        }
        [HttpPost]
        public async Task<ActionResult> FindAumphor(int? Province_id)
        {
            var prepareAllAumphure = await _context.Aumphures.Where(p => p.Province_id == Province_id).ToListAsync();
            var allAumphure = new SelectList(prepareAllAumphure, "Id", "Name_th", 0);
            return Json(allAumphure);
        }
        [HttpPost]
        public async Task<ActionResult> FindDistrict(int? Aumphure_id)
        {
            var prepareAllDistrict = await _context.Districts.Where(p => p.Aumphure_id == Aumphure_id).ToListAsync();
            var allDistrict = new SelectList(prepareAllDistrict, "Id", "Name_th", 0);
            return Json(allDistrict);
        }

        [Authorize(Roles = "Administrator")]
        private string UploadedFile(UserDetail model)
        {
            string uniqueFileName = null;

            if (model.UserImageForm != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imageSource\\UserImage");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.UserImageForm.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.UserImageForm.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}