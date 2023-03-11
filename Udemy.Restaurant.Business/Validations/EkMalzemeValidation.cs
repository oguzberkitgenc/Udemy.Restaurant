using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Validations
{
    public class EkMalzemeValidation : AbstractValidator<EkMalzeme>
    {
        public EkMalzemeValidation()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ek malzeme adı boş geçilemez").
                MaximumLength(50).WithMessage("Ek malzeme adı 50 Karakterden fazla girilemez");
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat bilgisi aralık dışında");
        }
    }
}
