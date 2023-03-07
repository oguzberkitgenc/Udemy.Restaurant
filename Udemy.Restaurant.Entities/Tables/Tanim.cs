using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Enums;
using Udemy.Restaurant.Entities.Tables.Base;

namespace Udemy.Restaurant.Entities.Tables
{
    public class Tanim : EntityBase
    {
        public string Adi { get; set; }
        public TanimTip TanimTip { get; set; }
    }
}
