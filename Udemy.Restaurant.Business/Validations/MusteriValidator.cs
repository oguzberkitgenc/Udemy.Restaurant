using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Validations
{
	public class MusteriValidator : AbstractValidator<Musteri>
	{
		public MusteriValidator()
		{
			RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı bilgisi 50 karakterden fazla olamaz");
			RuleFor(c => c.Adi).MinimumLength(3).WithMessage("Adı bilgisi 3 karakterden az olamaz");
			RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı bilgisi boş geçilemez");

			RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadı bilgisi 50 karakterden fazla olamaz");
			RuleFor(c => c.Soyadi).MinimumLength(3).WithMessage("Soyadı bilgisi 3 karakterden fazla olamaz");
			RuleFor(c => c.Soyadi).NotEmpty().WithMessage("Soyadı bilgisi boş geçilemez");


			RuleFor(c => c.KartNo).MaximumLength(20).WithMessage("Kart No bilgisi 20 karakterden fazla olamaz");
			RuleFor(c => c.Sirket).MaximumLength(100).WithMessage("Şirket bilgisi 100 karakterden fazla olamaz");
		}
	}
}
