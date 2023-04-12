using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables.Base;

namespace Udemy.Restaurant.Entities.Tables
{
	public class Musteri : EntityBase
	{
		public string Adi { get; set; }
		public string Soyadi { get; set; }
		public string Sirket { get; set; }
		public string KartNo { get; set; }
		public ICollection<Telefon> Telefonlar { get; set; }
		public ICollection<Adres> Adresler { get; set; }
	}
}
