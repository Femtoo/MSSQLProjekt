using DataAccess.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private AppDbContext _db;
        public VehicleRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
