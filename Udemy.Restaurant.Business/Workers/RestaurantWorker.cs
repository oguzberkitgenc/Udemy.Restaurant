using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Business.Managers;
using Udemy.Restaurant.Business.Services;
using Udemy.Restaurant.DataAccess.UnitOfWork;

namespace Udemy.Restaurant.Business.Workers
{
    public class RestaurantWorker : IWorker
    {
        private IUnitOfWork _uow;
        public IUrunServices UrunService { get; set; }
        public ITanimServices TanimService { get; set; }
        public IPorsiyonServices PorsiyonService { get; set; }
        public IEkMalzemeServices EkMalzemeService { get; set; }
        public IMusteriService MusteriService { get; set; }
        public ITelefonService TelefonService { get; set; }
        public IAdresService AdresService { get; set; }
        public RestaurantWorker(string connectionString=null)
        {
            //RestaruntUnitOfWork'de kontrol etmesi ve yapması gerekenler yazıyor. O yüzden burada tekrar yazmaya gerek yok
            _uow = new RestaurantUnitOfWork(connectionString);
            UrunService= new UrunManager(_uow);
            TanimService= new TanimManager(_uow);
            PorsiyonService = new PorsiyonManager(_uow);
            EkMalzemeService = new EkMalzemeManager(_uow); 
        }
        public bool Commit()
        {
            return _uow.Commit();
        }

        public void DetectChanges()
        {
            _uow.DetectChanges();
        }

        public bool HasChanger()
        {
            return _uow.HasChanges();
        }


        private bool disposedValue;
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
        // ~RestaurantWorker()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
