using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Enums;
using Udemy.Restaurant.Entities.Tables.Base;

namespace Udemy.Restaurant.Entities.Tables
{
	public class Telefon : EntityBase
	{
		public TelefonAdresTip TelefonTip { get; set; }
		public string Telefonu { get; set; }
		public Guid MusteriId { get; set; }
		public virtual Musteri Musteri { get; set; }
	}
}
