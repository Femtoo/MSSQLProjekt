using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        ILockerRepository LockerRepository { get; }
        IParcelRepository ParcelRepository { get; }
        IVehicleRepository VehicleRepository { get; }
        IWarehouseRepository WarehouseRepository { get; }
        IWorkerRepository WorkerRepository { get; }
        IPaymentRepository PaymentRepository { get; }
    }
}
