using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Contexts.Restaurant;
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

            Database.SetInitializer(new DropCreateDatabaseAlways<RestaurantContext>());
        }
        // RestaırntContext'in içindeki sınıfları(Tabloları) tanımlama
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<EkMalzeme> EkMalzemeler { get; set; }

        //EnityBase 'ı fluent api ile configure et
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                // ID kolonun anlaşabilmesi için 
                c.HasKey(e => e.Id);

                c.Property(e=>e.Ekleyen).HasMaxLength(30);
                c.Property(e=>e.Duzenleyen).HasMaxLength(30);
                c.Property(e => e.Aciklama).HasMaxLength(200);

                c.Property(e => e.Id).HasColumnName("id");
                c.Property(e => e.Duzenleyen).HasColumnName("Duzenleyen");
                c.Property(e => e.Ekleyen).HasColumnName("Ekleyen");
                c.Property(e => e.Aciklama).HasColumnName("Açıklama");
                c.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlemeTarihi");
                c.Property(e => e.EklenmeTarihi).HasColumnName("EklenmeTarihi");

            });
        }

    }
}
