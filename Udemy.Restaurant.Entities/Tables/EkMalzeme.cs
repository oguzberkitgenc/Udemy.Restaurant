using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Interfaces;
using Udemy.Restaurant.Entities.Tables.Base;

namespace Udemy.Restaurant.Entities.Tables
{
    public class EkMalzeme : EntityBase
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Guid UrunId { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
