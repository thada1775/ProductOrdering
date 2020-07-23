using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Helpers
{
    public class ThaiPostHelper : Controller
    {
        private readonly ApplicationDbContext _context;

        public ThaiPostHelper(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<JsonResult> FindAumphor(int? Province_id)
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
