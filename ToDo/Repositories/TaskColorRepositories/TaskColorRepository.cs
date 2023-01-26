using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Context;
using ToDo.Entitites;
using ToDo.Repositories.Base;

namespace ToDo.Repositories.TaskColorRepositories
{
    public class TaskColorRepository : Repository<TaskColor>, ITaskColorRepository
    {
        
        public TaskColorRepository(ToDoDBContext context):base(context)
        {
            
        }

       
    }
}
