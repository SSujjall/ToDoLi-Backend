using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Common
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}