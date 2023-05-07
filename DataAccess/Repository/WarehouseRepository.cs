using DataAccess.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        private AppDbContext _db;
        public WarehouseRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
