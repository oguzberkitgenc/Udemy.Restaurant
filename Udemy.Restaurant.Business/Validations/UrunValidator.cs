using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Validations
{
    public class UrunValidator : AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ürün adı boş geçilemez").
                MaximumLength(50).WithMessage("Ürün adı 50 Karakterden fazla girilemez");
            RuleFor(c => c.Barkod).MaximumLength(50).WithMessage("Barkod 50 Karakterden fazla girilemez");
        }
    }
}
