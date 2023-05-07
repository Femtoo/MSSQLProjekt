using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Parcel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int? SenderId { get; set; }
        public Customer Sender { get; set; }
        public int? ReceiverId { get; set; }
        public Customer Receiver { get; set; }

        public int? FromLockerId { get; set; }
        public Locker FromLocker { get; set; }

        public int? ToLockerId { get; set; }
        public Locker ToLocker { get; set; }
        public int WorkerId { get; set; }
        public Worker Worker { get; set; }
        public int? PaymentId { get; set; }
        public Payment Payment { get; set; }
        public DateTime? Posted { get; set; }
        public DateTime? Received { get; set;}
    }
}
