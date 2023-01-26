using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.DTO.TaskColor;
using ToDo.BLL.DTO.ToDoTask;

namespace ToDo.BLL.Mapping.TaskColor
{
    public class TaskColorProfile:Profile
    {
        public TaskColorProfile()
        {
            CreateMap<ToDo.Entitites.TaskColor, TaskColorDTO>().ReverseMap();
        }
    }
}
