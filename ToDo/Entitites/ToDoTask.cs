
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ToDo.Entitites.Enums;

namespace ToDo.Entitites
{
    public class ToDoTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(50),MinLength(1)]
        public string? Title { get; set; } 

        public string? Description { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int TaskColorId { get; set; }

        public string? Place { get; set; }

        [Required]
        public ToDoTaskStatus Status { get; set; }

        public virtual TaskColor? TaskColor { get; set; }
    }
}
