using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Interfaces;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.DataAccess.Dals
{
	public class MusteriDal : Repository<Musteri>, IMusteriDal
	{
		public MusteriDal(DbContext context) : base(context)
		{

		}
	}
}
