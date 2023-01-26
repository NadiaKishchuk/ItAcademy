using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Context;
using ToDo.Entitites;
using ToDo.Repositories.Base;

namespace ToDo.Repositories.ToDoTaskRepositories
{
    public class ToDoTaskRepository : Repository<ToDoTask>, IToDoTaskRepository
    {
        public ToDoTaskRepository(ToDoDBContext context) : base(context)
        {
        }

        public ToDoTask GetById(int id) => context.Set<ToDoTask>().First(t => t.Id == id);

        public void Update(ToDoTask task)
        {
            ToDoTask contextTask= context.ToDoTasks.First(t => t.Id == task.Id);
            contextTask.Status = task.Status;
            contextTask.Title = task.Title;
            contextTask.Description = task.Description;
            contextTask.Place = task.Place;
            contextTask.DateTime = task.DateTime;
           

        }

        public void UpdateColor(int id, int colorId)
        {
            var item=context.ToDoTasks.FirstOrDefault(t => t.Id == id);
            if (item == null)
                throw new ArgumentException($"No task with id = {id}");
            item.TaskColorId = colorId; 
        }
    }
}
