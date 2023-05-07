using DataAccess.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ParcelRepository : Repository<Parcel>, IParcelRepository
    {
        private AppDbContext _db;
        public ParcelRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Parcel entity) 
        {
            _db.Update(entity);
        }
    }
}
