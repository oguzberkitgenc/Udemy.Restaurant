using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Contexts.Base;
using System.Data.Entity;
using Udemy.Restaurant.Entities.Tables;
using Udemy.Restaurant.DataAccess.Mappings;
using Udemy.Restaurant.Entities.Tables.Base;
using System.Data.Entity.ModelConfiguration.Conventions;

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

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<RestaurantContext, RestaurantConfiguration>());
        }
        // RestaırntContext'in içindeki sınıfları(Tabloları) tanımlama
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Porsiyon> Porsiyonlar { get; set; }
        public DbSet<EkMalzeme> EkMalzemeler { get; set; }

        //EnityBase 'ı fluent api ile configure et
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // DbContexin kuralları
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>(); //Çoka çok ilişkide sil
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // Bağlantılı tabloları sil
            modelBuilder.Types<EntityBase>().Configure(c =>
            {
                // ID kolonun anlaşabilmesi için 
                c.HasKey(e => e.Id);

                c.Property(e => e.Ekleyen).HasMaxLength(30);
                c.Property(e => e.Duzenleyen).HasMaxLength(30);
                c.Property(e => e.Aciklama).HasMaxLength(200);

                c.Property(e => e.Id).HasColumnName("id");
                c.Property(e => e.Duzenleyen).HasColumnName("Duzenleyen");
                c.Property(e => e.Ekleyen).HasColumnName("Ekleyen");
                c.Property(e => e.Aciklama).HasColumnName("Açıklama");
                c.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlemeTarihi");
                c.Property(e => e.EklenmeTarihi).HasColumnName("EklenmeTarihi");

            });
            // HasRequired: Kesin olmalı /- With Many: Çok ilişki - HasForeignKey Kolon ismi        //WillCascadeOnDelete: Porsiyon tablosu ürün tablosu silindiğinde ürünün bağlı olduğu porsiyonlarda silinsin
            modelBuilder.Entity<Porsiyon>().HasRequired(c => c.Urun).WithMany(c => c.Porsiyonlar).HasForeignKey(c => c.UrunId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Porsiyon>().HasRequired(c => c.Birim).WithOptional().Map(c => c.MapKey("BirimId"));
            modelBuilder.Entity<EkMalzeme>().HasRequired(c => c.Urun).WithMany(c => c.EkMalzemeler).HasForeignKey(c => c.UrunId);
            modelBuilder.Entity<Urun>().HasRequired(c => c.UrunGrup).WithOptional().Map(c => c.MapKey("UrunGrupId"));


            modelBuilder.Configurations.Add(new UrunMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PorsiyonMap());
            modelBuilder.Configurations.Add(new EkMalzemeMap());
        }

    }
}
