using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaerskWebApp.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public int ScheduleId {get;set;}
        public virtual Schedule Schedule { get; set; }
        public string CustomerName { get; set; }
        public int NumOfContainter { get; set; }
    }
}
