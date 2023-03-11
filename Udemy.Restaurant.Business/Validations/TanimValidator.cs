using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Validations
{
    public class TanimValidator : AbstractValidator<Tanim>
    {
        public TanimValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Tanım girii 50 karakterden fazla olamaz").
                NotEmpty().WithMessage("Tanım boş geçilemez");
        }
    }
}
