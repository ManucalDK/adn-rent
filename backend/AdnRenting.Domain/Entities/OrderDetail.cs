using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Domain.Entities
{
    public class OrderDetail : EntityBase
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public virtual Order Order { get; set; }
    }
}
