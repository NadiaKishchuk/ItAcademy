using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.DTO.ToDoTask;
using ToDo.Entitites;

namespace ToDo.BLL.Mapping.ToDoTask
{
    public class ToDoTaskProfile:Profile
    {
        public ToDoTaskProfile()
        {
            CreateMap<ToDo.Entitites.ToDoTask, NewToDoTask>().ReverseMap();
            CreateMap<ToDo.Entitites.ToDoTask, ToDoTaskDTO>().ReverseMap();
        }
    }
}
