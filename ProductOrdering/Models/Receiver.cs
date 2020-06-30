using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class Receiver
    {
        [Display(Name = "รหัสผู้รับ")]
        public int ReceiverId { get; set; }
        [Display(Name = "ชื่อผู้รับ")]
        public string Name { get; set; }
        [Display(Name = "นามสกุลผู้รับ")]
        public string Lastname { get; set; }
        [Display(Name = "เบอร์โทร")]
        public string Tel { get; set; }
        [Display(Name = "ที่อยู่")]
        public string Address { get; set; }
        [Display(Name = "รหัสตำบล")]
        public int District_id { get; set; }
        public virtual District? District { get; set; }

        public virtual Aumphure? Aumphure { get; set; }
        [Display(Name = "รหัสอำเภอ")]
        public int Aumphure_id { get; set; }
        public virtual Province? Province { get; set; }
        [Display(Name = "รหัสจังหวัด")]
        public int Province_id { get; set; }
        [Display(Name = "รหัสรายการสั่งซื้อ")]
        public int OrderingId { get; set; }
        public virtual Ordering? Ordering { get; set; }

        [NotMapped]
        public string? FullAddress
        {
            get
            {
                if (District != null && Aumphure != null && Province != null)
                {
                    String address = $"{Address} ต.{District.Name_th} อ.{Aumphure.Name_th} จ.{Province.Name_th} {District.Zip_code}";
                    return address;
                }
                return null;
            }
        }

        //public Receiver()
        //{
        //    District = new District();
        //    Aumphure = new Aumphure();
        //    Province = new Province();
        //}
        public string GetAddress()
        {
            //String address = Address + " ต." + District.Name_th + " อ." + Aumphure.Name_th + " จ." + Province.Name_th + " " + District.Zip_code;
            String address = $"{Address} ต.{District.Name_th} อ.{Aumphure.Name_th} จ.{Province.Name_th} {District.Zip_code}";
            return address;
        }
    }
}
