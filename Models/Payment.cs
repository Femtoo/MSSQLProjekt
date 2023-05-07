using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int Price { get; set; }
        public int ParcelId { get; set; }
        public Parcel Parcel { get; set; }
    }
}
