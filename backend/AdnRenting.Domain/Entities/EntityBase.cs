using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdnRenting.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
    }
}
