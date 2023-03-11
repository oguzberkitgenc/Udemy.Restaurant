using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Restaurant.Business.Managers.Base;
using Udemy.Restaurant.Business.Services;
using Udemy.Restaurant.DataAccess.UnitOfWork;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.Business.Managers
{
    public class PorsiyonManager : BaseManager<Porsiyon>, IPorsiyonServices
    {
        public PorsiyonManager(IUnitOfWork uow) : base(uow)
        {
        }
    }
}
