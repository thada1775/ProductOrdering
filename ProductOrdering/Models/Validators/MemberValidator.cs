using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Validators
{
    public class MemberValidator : AbstractValidator<Receiver>
    {
        public MemberValidator()
        {
            RuleFor(m => m.Province_id)
                .NotEmpty()
                .WithMessage("กรุณาเลือกสินค้า");
            RuleFor(m => m.Name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("กรุณากรอกชื่อผู้รับ")
                .MinimumLength(1)
                .WithMessage("ชื่อผู้รับต้องมีอย่างน้อย 1 ตัวอักษร")
                .MaximumLength(20)
                .WithMessage("ชื่อผู้รับห้ามเกิน 20 ตัวอักษร");
            RuleFor(m => m.Lastname)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("กรุณากรอกนามสกุลผู้รับ")
                .MinimumLength(1)
                .WithMessage("นามสกุลผู้รับต้องมีอย่างน้อย 1 ตัวอักษร")
                .MaximumLength(20)
                .WithMessage("นามสกุลผู้รับห้ามเกิน 20 ตัวอักษร");
            RuleFor(m => m.Tel)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("กรุณากรอกเบอร์มือถือ")
                .Matches("^0[1-9]\\d{8}$|^0[1-9]\\d{7}$")
                .WithMessage("เบอร์โทรศัพท์ไม่ถูกต้อง");
            RuleFor(m => m.Address)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage("กรุณากรอกที่อยู่")
                .MaximumLength(300);
            RuleFor(m => m.District_id)
                .NotEmpty()
                .WithMessage("กรุณาเลือกตำบล");
            RuleFor(m => m.Aumphure_id)
                .NotEmpty()
                .WithMessage("กรุณาเลือกอำเภอ");
            RuleFor(m => m.Province_id)
                .NotEmpty()
                .WithMessage("กรุณาเลือกจังหวัด");
        }
    }
}
