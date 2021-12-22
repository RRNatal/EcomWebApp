using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository.IRepository
{
    public interface IMainCatRepository : IRepository<MainCat>
    {
        void Update(MainCat obj);
       
    }
}
