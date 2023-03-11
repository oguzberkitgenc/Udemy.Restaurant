using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Restaurant.Business.Workers
{
    public interface IWorker : IDisposable
    {
        bool HasChanger();
        void DetectChanges();
        bool Commit();
    }
}
