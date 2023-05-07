using DataAccess.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class LockerRepository : Repository<Locker>, ILockerRepository
    {
        private AppDbContext _db;
        public LockerRepository(AppDbContext db) : base(db) 
        {
            _db = db;
        }
    }
}
