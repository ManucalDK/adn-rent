using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Domain.Entities
{
    public class Order : Base
    {
        public Guid OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual User User { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        public virtual Bill Bill { get; set; }
    }
}
