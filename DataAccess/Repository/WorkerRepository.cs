using DataAccess.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        private AppDbContext _db;
        public WorkerRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
