using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using ProductOrdering.Models;
using ProductOrdering.Models.ViewModels;

namespace ProductOrdering.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class UserManagementController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _usermanager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public UserManagementController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _usermanager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var allUsers = await _context.Users.Include(u => u.UserDetail).ToListAsync();
            return View(allUsers);
        }


        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _usermanager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }

            // GetClaimsAsync retunrs the list of user Claims
            //var userClaims = await _usermanager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            var userRoles = await _usermanager.GetRolesAsync(user);
            var userDetail = await _context.UserDetails.Where(u => u.UserId == user.Id).FirstOrDefaultAsync();
            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                Roles = userRoles,
                IsEnabled = user.IsEnabled,
                UserDetail = userDetail
            };

            var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th");

            var allAumphure = await _context.Aumphures.Where(a => a.Province_id == userDetail.Province_id).OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.Aumphure_id = new SelectList(allAumphure, "Id", "Name_th");

            var allDistrict = await _context.Districts.Where(d => d.Aumphure_id == userDetail.Aumphure_id).OrderBy(p => p.Name_th).ToListAsync();
            ViewBag.District_id = new SelectList(allDistrict, "Id", "Name_th");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await _usermanager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                if (model.IsEnabled) user.EmailConfirmed = true;
                else user.EmailConfirmed = false;

                user.IsEnabled = model.IsEnabled;
                user.UserDetail.FirstName = model.UserDetail.FirstName;
                user.UserDetail.LastName = model.UserDetail.LastName;
                user.UserDetail.Tel = model.UserDetail.Tel;
                user.UserDetail.Address = model.UserDetail.Address;
                user.UserDetail.Province_id = model.UserDetail.Province_id;
                user.UserDetail.Aumphure_id = model.UserDetail.Aumphure_id;
                user.UserDetail.District_id = model.UserDetail.District_id;

                var result = await _usermanager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                var allProvince = await _context.Provinces.OrderBy(p => p.Name_th).ToListAsync();
                ViewBag.Province_id = new SelectList(allProvince, "Id", "Name_th");

                var allAumphure = await _context.Aumphures.Where(a => a.Province_id == model.UserDetail.Province_id).OrderBy(p => p.Name_th).ToListAsync();
                ViewBag.Aumphure_id = new SelectList(allAumphure, "Id", "Name_th");

                var allDistrict = await _context.Districts.Where(d => d.Aumphure_id == model.UserDetail.Aumphure_id).OrderBy(p => p.Name_th).ToListAsync();
                ViewBag.District_id = new SelectList(allDistrict, "Id", "Name_th");

                return View(model);
            }
        }


        [HttpGet]
        public async Task<IActionResult> ManageUserRoles(string userId)
        {
            ViewBag.userId = userId;

            var user = await _usermanager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRolesViewModel>();

            var allRoles = await _roleManager.Roles.ToListAsync(); ;
            foreach (var role in allRoles)
            {
                var userRolesViewModel = new UserRolesViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                var IsInRole = await _usermanager.IsInRoleAsync(user, role.Name);
                if (IsInRole)
                {
                    userRolesViewModel.IsSelected = true;
                }
                else
                {
                    userRolesViewModel.IsSelected = false;
                }

                model.Add(userRolesViewModel);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRolesViewModel> model, string userId)
        {
            var user = await _usermanager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            var roles = await _usermanager.GetRolesAsync(user);
            var result = await _usermanager.RemoveFromRolesAsync(user, roles);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }

            result = await _usermanager.AddToRolesAsync(user,
                model.Where(x => x.IsSelected).Select(y => y.RoleName));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }

            return RedirectToAction("EditUser", new { Id = userId });
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
