using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Validations
{
    public class PorsiyonValidation : AbstractValidator<Porsiyon>
    {
        public PorsiyonValidation()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Porsiyon girişi 50 karakterden fazla olamaz");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10,false).WithMessage("Fiyat bilgisi aralık dışında");
            RuleFor(c => c.EkMalzemeCarpan).ScalePrecision(2, 4,false).WithMessage("Çarpan bilgisi aralık dışında");
        }
    }
}
