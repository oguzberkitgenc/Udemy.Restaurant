using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Contexts.Base;
using System.Data.Entity;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.DataAccess.Contexts.Restaurant
{
    public class RestaurantContext : BaseContext<RestaurantContext>
    {
        public RestaurantContext()
        {

        }
        public RestaurantContext(string connectionString) : base(connectionString)
        {
            // Database oluştuğunda nasıl davranacağını söylüyoruz.
            // MigrateDatabaseToLatestVersion: Tablolara bak, eğer bir şey değiştiyse güncelle
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantContext,RestaurantConfiguration>());
        }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<EkMalzeme> EkMalzemeler { get; set; }

    }
}
