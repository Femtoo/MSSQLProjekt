using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Locker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set;}
        public List<Parcel> FromLockerDelivery { get; set; } = new List<Parcel>();
        public List<Parcel> ToLockerDelivery { get; set; } = new List<Parcel>();
    }
}
