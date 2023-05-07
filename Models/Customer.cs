using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public List<Parcel> SentShipments { get; set; } = new List<Parcel>();
        public List<Parcel> ReceivedShipments { get; set; } = new List<Parcel>();
    }
}
