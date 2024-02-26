using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
