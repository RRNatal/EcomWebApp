using Ecom.DataAccess.Data;
using Ecom.DataAccess.Repository.IRepository;
using Ecom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.DataAccess.Repository
{
    public class MainCatRepository : Repository<MainCat>, IMainCatRepository
    {
        private readonly ApplicationDbContext _db;

        public MainCatRepository(ApplicationDbContext db) : base(db)
        {
            _db= db;
        }
       

        public void Update(MainCat obj)
        {
            var objFromDb = _db.MainCat.FirstOrDefault(u => u.Id == obj.Id);
            objFromDb.Name = obj.Name;
        }
    }
}
