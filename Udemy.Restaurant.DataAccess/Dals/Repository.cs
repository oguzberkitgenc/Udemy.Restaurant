using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.DataAccess.Interfaces.Base;
using Udemy.Restaurant.Entities.Interfaces;

namespace Udemy.Restaurant.DataAccess.Dals
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }
        private bool disposedValue;

        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added; // context'e entity gönderiyor.
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
        }

        public void AddOrUpdate(TEntity entity)
        {
            _context.Set<TEntity>().AddOrUpdate(entity);
        }

        public void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Set<TEntity>().AddOrUpdate(entity);
            }
        }
        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
        }
        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _context.Set<TEntity>().RemoveRange(_context.Set<TEntity>().Where(filter));
        }

        public bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().Any(filter); // DB Contextten gelen "Any" ile filter sorgulama yapılıp değeri geri döndürecek.
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        { 
            return _context.Set<TEntity>().SingleOrDefault(filter); // SingleOrDefault : Bana bi tane filter olarak veri yolla
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>>[] includes)
        {
             
            return filter == null 
                ? _context.Set<TEntity>().AsNoTracking().ToList()  // AsNoTracking: EnityStae durumu önemli değil,// bana tabloyla ilgili ekleme, güncelleme bilgilerinin gelmesini istemiyorum.
                : _context.Set<TEntity>().Where(filter).AsNoTracking().ToList();  //Filtre boşşsa hiç bir şey yapmadan geri yolla ama filtre doluysa
        }

        public bool HasChanges()
        {
            return _context.ChangeTracker.Entries<TEntity>().Any(); // contexte ChangeTracker o an içindeki yapılan değişikliliklere bak TEntity tablosu için
                                                                    // her hangi bir değişiklilik varsa true yoksa false geri gönder
        }

        public void Load(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, object>>[] includes)
        {
            if (filter==null) 
            {
                _context.Set<TEntity>().Load();
            }
            else
            {
                _context.Set<TEntity>().Where(filter).Load();
            }
              
        }

        public IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null 
                ? _context.Set<TEntity>().Select(selector)
                : _context.Set<TEntity>().Where(filter).Select(selector);
        }

        public IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, Expression<Func<TEntity, object>>[] includes)
        {
            return filter == null ?
                 _context.Set<TEntity>().Select(selector) 
                 : _context.Set<TEntity>().Where(filter).Select(selector);
        }

        public BindingList<TEntity> BindingList()
        {
            return _context.Set<TEntity>().Local.ToBindingList(); //ToBindingList bizim localde çalışmamızı sağlıyor
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Repository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this); // Ram Temizleme
        }
    }
}
