using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ParcelDTO
    {
        public string Name { get; set; }
        public string State { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }

        public int FromLockerId { get; set; }

        public int ToLockerId { get; set; }
        public int WorkerId { get; set; }
        public DateTime Posted { get; set; }
    }
}
