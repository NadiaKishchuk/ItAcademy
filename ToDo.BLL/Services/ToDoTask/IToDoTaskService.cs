using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.DTO.ToDoTask;

namespace ToDo.BLL.Services.ToDoTask
{
    public interface IToDoTaskService
    {
        void Add(NewToDoTask newtask);
        void Remove(int id);
        void ChangeColor(int id, int colorId);
        void Update(ToDoTaskDTO updatedTask);

        IEnumerable<ToDoTaskDTO> GetAllTasks();

    }
}
