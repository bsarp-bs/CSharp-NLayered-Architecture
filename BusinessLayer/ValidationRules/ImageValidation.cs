using EntityLayer.Concrete_Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidation : AbstractValidator<Images>
    {
        public ImageValidation() 
        {
            RuleFor(x => x.ImgURL).NotEmpty().WithMessage("Boş Geçilemez");

        }
    }
}
