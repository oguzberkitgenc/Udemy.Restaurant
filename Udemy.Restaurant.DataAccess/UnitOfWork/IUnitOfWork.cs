using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Interfaces.Base;
using Udemy.Restaurant.Entities.Interfaces;

namespace Udemy.Restaurant.DataAccess.UnitOfWork
{
    //IDısposable: Kullanılmıyorsa RAM'den çıkar
    public interface IUnitOfWork : IDisposable 
    {
        IRepository<TEntity> Dal<TEntity>() where TEntity : class,IEntity,new();
        bool HasChanges(); // Database'deki bütün tablolardaki her hangi bir değişikliği sorgula 
        bool DetectChanges(); // Değişiklikleri fark et (Context reflesh / tazeleme)
        bool Commit(); // En son değişiklikleri veritabanına aktar

    }
}
