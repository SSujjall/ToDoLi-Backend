using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{
    public class TodoItem
    {
        [Key]
        public Guid TodoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public bool IsCompleted { get; set; }


        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}