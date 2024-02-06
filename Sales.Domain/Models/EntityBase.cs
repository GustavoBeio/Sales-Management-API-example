using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Models
{
    public abstract class EntityBase
    {
        protected string Id { get; set; }
        protected DateTime CreatedAt { get; set; }
    }
}
