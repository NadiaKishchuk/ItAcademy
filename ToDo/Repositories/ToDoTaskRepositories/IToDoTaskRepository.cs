using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Entitites;
using ToDo.Repositories.Base;

namespace ToDo.Repositories.ToDoTaskRepositories
{
    public interface IToDoTaskRepository: IRepository<ToDoTask>
    {
        ToDoTask GetById(int id);
        void UpdateColor(int id, int colorId);
        void Update(ToDoTask task);
        
    }
}
