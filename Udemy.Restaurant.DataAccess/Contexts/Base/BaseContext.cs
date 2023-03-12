using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Contexts.Restaurant;
using Udemy.Restaurant.DataAccess.Mappings;
using Udemy.Restaurant.Entities.Tables;
using Udemy.Restaurant.Entities.Tables.Base;

namespace Udemy.Restaurant.DataAccess.Contexts.Base
{
    public class BaseContext<TContext> : DbContext where TContext : DbContext, new()
    {
        // Default olarak istediği için default ctor oluşturduk. Kullanmayacağız.
        private static string ConnectionString = "";
        public BaseContext() : base(ConnectionString)
        {

        }
        public BaseContext(string connectionString) : base(connectionString)
        {
            // LazyLoading : Tablolar yüklenirken, tablolarla birlikte ilişkilerinde olarak yüklendiği tip. // Kapattık. Sadece tablolar gelecek.
            Configuration.LazyLoadingEnabled = false;
            ConnectionString=connectionString;

            // Database.SetInitializer(new DropCreateDatabaseAlways<RestaurantContext>());

        }
    }
}
