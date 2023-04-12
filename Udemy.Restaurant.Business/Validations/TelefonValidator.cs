using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Validations
{
	public class TelefonValidator : AbstractValidator<Telefon>
	{
		public TelefonValidator()
		{
			RuleFor(c=>c.Telefonu).MaximumLength(20).WithMessage("Telefon bilgisi 20 karakterden fazla olamaz")
			RuleFor(c=>c.Telefonu).MinimumLength(14).WithMessage("Telefon bilgisi 14 karakterden fazla olamaz")
		}
	}
}
