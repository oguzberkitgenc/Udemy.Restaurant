using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Restaurant.DataAccess.Contexts.Restaurant
{
    public class RestaurantConfiguration : DbMigrationsConfiguration<RestaurantContext>
    {
        public RestaurantConfiguration()
        {
            // Karşılaştırmanın yapılabilmesi için aktif edilmesi gerek
            // AutomaticMigrationsEnabled : Eğer bir değişiklik varsa oto olarak mig devreye sok.
            AutomaticMigrationsEnabled = true;
            //DataLossAllowed: Veri kayıplarını kabul et !
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
