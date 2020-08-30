using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProductOrdering.Models
{
    public class Product
    {
        [Display(Name = "รหัสสินค้า")]
        public int ProductId { get; set; }
        [Display(Name = "ชื่อ")]
        public string Name { get; set; }
        [Display(Name = "คงเหลือ")]
        public int Amount { get; set; }
        [Display(Name = "ราคา")]
        public decimal Price { get; set; }
        [Display(Name = "หมวด")]
        public int CategoryId { get; set; }
        [Display(Name = "รูป")]
        public string? ProductImage { get; set; }
        public virtual Category? Category { get; set; }
        public ICollection<Ordering>? Orderings { get; }
    }
}
