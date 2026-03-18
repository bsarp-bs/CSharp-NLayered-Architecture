using EntityLayer.Concrete_Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class StaffValidation : AbstractValidator<Staff>
    {
        public StaffValidation()
        {
             
            RuleFor(x=>x.StaffName).NotEmpty().WithMessage("Personel Adı Boş Geçilemez");
            RuleFor(x => x.WorkType).NotEmpty().WithMessage("İş Tipi Geçilemez");
            RuleFor(x => x.StaffName).MinimumLength(5).WithMessage("İsim En Az 5 Harf'den Oluşmalı!");
        }
    }
}
