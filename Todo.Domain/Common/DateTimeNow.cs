using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Common
{
    public static class DateTimeNow
    {
        public static DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}