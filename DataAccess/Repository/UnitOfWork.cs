using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            CustomerRepository = new CustomerRepository(_db);
            LockerRepository = new LockerRepository(_db);
            ParcelRepository = new ParcelRepository(_db);
            VehicleRepository = new VehicleRepository(_db); 
            WarehouseRepository = new WarehouseRepository(_db);
            WorkerRepository = new WorkerRepository(_db);
            PaymentRepository = new PaymentRepository(_db);
        }
        public ICustomerRepository CustomerRepository { get; }
        public ILockerRepository LockerRepository { get; }
        public IParcelRepository ParcelRepository { get; }
        public IVehicleRepository VehicleRepository { get; }
        public IWarehouseRepository WarehouseRepository { get; }
        public IWorkerRepository WorkerRepository { get; }
        public IPaymentRepository PaymentRepository { get; }
    }
}
