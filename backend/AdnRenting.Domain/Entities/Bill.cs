using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Domain.Entities
{
    public class Bill : EntityBase
    {
        public virtual Guid OrderId { get; set; }
        public virtual Order Order { get; set; }
        public DateTime ProcessStartDate { get; set; }
        public DateTime ProcessEndDate { get; set; }
        public bool Status { get; set; }
        public Guid AprobationNumber { get; set; }
        public string InvoiceSupportUrl { get; set; }


    }
}
