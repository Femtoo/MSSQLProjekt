using DataAccess.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private AppDbContext _db;
        public CustomerRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

    }
}
