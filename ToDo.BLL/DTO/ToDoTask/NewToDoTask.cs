using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entitites.Enums;

namespace ToDo.BLL.DTO.ToDoTask
{
    public class NewToDoTask
    {

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime DateTime { get; set; }

        public int TaskColorId { get; set; }

        public string? Place { get; set; }

        public ToDoTaskStatus Status { get; set; }

    }
}
