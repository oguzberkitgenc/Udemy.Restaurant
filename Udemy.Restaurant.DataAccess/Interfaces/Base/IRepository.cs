using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using Udemy.Restaurant.Entities.Interfaces;

namespace Udemy.Restaurant.DataAccess.Interfaces.Base
{
    public interface IRepository<TEntity>:IDisposable where TEntity : class,IEntity,new() //IRepsitory Class olmalı, IEntity Olmalı ve New'lenebilmeli.
                                                                                          //IDıspoasble ile gereksiz harcamayı sonlandır. (Tamamen hafızadan yok et)
    {
        void Add(TEntity entity); // tek ise ekle
        void Add(IEnumerable<TEntity> entities); // birden fazla ise ekle (overload)
        void AddOrUpdate(TEntity entity); // tek ise eklye veya güncelle
        void AddOrUpdate(IEnumerable<TEntity> entities); // birden fazla ise ekle veya güncelle (overload)
        void Update(TEntity entity); // tek ise güncelle
        void Update(IEnumerable<TEntity> entities); // birden fazla ise güncelle (overload)
        void Delete(TEntity entity); // tek ise sil
        void Delete(IEnumerable<TEntity> entities); // birden fazla ise sil (overload)
        void Delete(Expression<Func<TEntity, bool>> filter); // Expression tipinde func yolluyoruz. TEntity tipinde veri gönder geri dönüş tipi bool (true false). Filtre olsun
        TEntity Get(Expression<Func<TEntity, bool>> filter,params Expression<Func<TEntity, object>>[] includes ); //params : birden fazla verinin yollanabildiği paramtere yollabilir. Expression Array tipinde
        bool Exist(Expression<Func<TEntity, bool>> filter); // Sorgulama: Varsa True yoksa False
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter,params Expression<Func<TEntity, object>>[] includes); // Örnek: ürünleri ve bağlı tabloları listele
        IQueryable<TEntity> Select(Expression<Func<TEntity,bool>> filter,Expression<Func<TEntity,TEntity>> selector,params Expression<Func<TEntity, object>>[] includes); // IQueryable: Tablodan sadece istenen sutunları sorgula ve listele
        IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector,params Expression<Func<TEntity, object>>[] includes);
        void Load(Expression<Func<TEntity,bool>> filter,params Expression<Func<TEntity, object>>[] includes);
        bool HasChanges(); // Formda veri değişikliği kontrol et. Eğer veri değişikliği varsa uyar. (From kapanırken gelecek)
        BindingList<TEntity> BindingList();// Gridlerle anlık olarak çalışmayı sağlayan method. // Load methoduyla birlikte çalışır
    }
}
