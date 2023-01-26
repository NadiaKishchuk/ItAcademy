using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Entitites
{
    public class TaskColor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MinLength(4),MaxLength(7)]
        public string? ColorString { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string? Name { get; set; }

        public virtual ICollection<ToDoTask>? Tasks { get; set; } 

    }
}
