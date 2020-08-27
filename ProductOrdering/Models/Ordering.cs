using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class Ordering
    {
        [Display(Name ="รหัสรายการ")]
        public int OrderingId { get; set; }

        [Display(Name = "ตัวแทนจำหน่าย")]
        public String? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        [Display(Name = "สินค้า")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Display(Name = "รูปแบบ")]
        public Payment Payment { get; set; }
        [Display(Name = "สถานะ")]
        public Status Status { get; set; }
        [Display(Name = "ลดราคา")]
        public decimal? Discount { get; set; }

        [Display(Name = "จำนวน")]
        public int Amount { get; set; }
        [Display(Name = "เงินรวม")]
        public decimal? TotalPrice { get; set; }
        [Display(Name = "เวลา")]
        public DateTime Time { get; set; }
        public Receiver? Receiver { get; set; }     
        public string? CancelUserId { get; set; }
        public virtual ApplicationUser? UserCancel { get; set; }

    }
    public enum Payment
    {
        [Display(Name="ชำระเงินปลายทาง")]
        CashOnDelivery,

        [Display(Name = "ชำระเงินเสร็จสิ้น")]
        Paid
    }

    public enum Status
    {
        [Display(Name = "กำลังส่ง")]
        Sending,

        [Display(Name = "ส่งสำเร็จ")]
        CompleteSending,

        [Display(Name = "ยกเลิก")]
        CancleOrder
    }
}
