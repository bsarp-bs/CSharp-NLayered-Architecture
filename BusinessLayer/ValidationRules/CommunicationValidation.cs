using EntityLayer.Concrete_Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BusinessLayer.ValidationRules
{
    public class CommunicationValidation : AbstractValidator<Communication>
    {
        public CommunicationValidation() 
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İletişim Adı Boş Geçilemez");
        }
    }
}
