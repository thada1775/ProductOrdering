using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class UserDetail
    {
        public int UserDetailId { get; set; }
        [Display(Name = "ชื่อผู้ใช้")]
        public string FirstName { get; set; }
        [Display(Name = "นามสกุลผู้ใช้")]
        public string LastName { get; set; }
        [Display(Name = "เบอร์โทร")]
        public string Tel { get; set; }
        [Display(Name = "ที่อยู่")]
        public string Address { get; set; }
        [Display(Name = "ตำบล")]
        public int District_id { get; set; }
        public virtual District? District { get; set; }
        public virtual Aumphure? Aumphure { get; set; }
        [Display(Name = "อำเภอ")]
        public int Aumphure_id { get; set; }
        public virtual Province? Province { get; set; }
        [Display(Name = "จังหวัด")]
        public int Province_id { get; set; }
        [Display(Name = "รหัสผู้ใช้")]
        public string? UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

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
    }
}
