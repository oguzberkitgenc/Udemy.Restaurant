using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Entities.Tables.Base;

namespace Udemy.Restaurant.DataAccess.Functions
{
    public static class EntityBaseInfo
    {
        public static void Add(DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries()) // Context içinde değişenleri dolaş
            {
                EntityBase changingEntity = (EntityBase)entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changingEntity.Id==Guid.Empty)
                        {
                            changingEntity.Id = Guid.NewGuid();
                        }
                        changingEntity.EklenmeTarihi=DateTime.Now;
                        changingEntity.Ekleyen = "OBG";
                        break;
                    case EntityState.Modified:
                        changingEntity.DuzenlenmeTarihi= DateTime.Now;
                        changingEntity.Duzenleyen = "OBG";
                        break;
                }
            }
        }
    }
}
