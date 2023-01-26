
using AutoMapper;
using ToDo.BLL.DTO.ToDoTask;
using ToDo.Repositories.ToDoTaskRepositories;

namespace ToDo.BLL.Services.ToDoTask
{
    public class ToDoTaskService:IToDoTaskService
    {
        private readonly IToDoTaskRepository repository;
        private readonly IMapper mapper;
        public ToDoTaskService(IToDoTaskRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }


        public void Add(NewToDoTask newtask)
        {
            var task = mapper.Map<NewToDoTask, Entitites.ToDoTask>(newtask);
            repository.Add(task);
            repository.SaveChanges();
        }

        public void ChangeColor(int id, int colorId)
        {
            repository.UpdateColor(id, colorId);
            repository.SaveChanges();
        }

        public void Remove(int id)
        {
            repository.Delete(repository.FirstOrDefault(t => t.Id == id));
            repository.SaveChanges();
            
        }

        public IEnumerable<ToDoTaskDTO> GetAllTasks()
        {
            return mapper.Map< IEnumerable <Entitites.ToDoTask>, IEnumerable<ToDoTaskDTO>>( repository.GetAll());
        }
        public void Update(ToDoTaskDTO updatedTask)
        {
            var task = mapper.Map<ToDoTaskDTO, Entitites.ToDoTask>(updatedTask);
            repository.Update(mapper.Map<ToDoTaskDTO, Entitites.ToDoTask>(updatedTask));
            repository.SaveChanges();

        }

        
    }
}
