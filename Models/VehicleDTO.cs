using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VehicleDTO
    {
        public string Name { get; set; }
        public bool IsAvailable { get; set; }
        public int WorkerId { get; set; }
    }
}
