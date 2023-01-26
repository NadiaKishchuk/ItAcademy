using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.DTO.TaskColor;
using ToDo.Repositories.TaskColorRepositories;

namespace ToDo.BLL.Services.TaskColor
{
    public class TaskColorService : ITaskColorService
    {
        readonly ITaskColorRepository repository;
        readonly IMapper _mapper;
        public TaskColorService(ITaskColorRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this._mapper = mapper;
        }
        public IEnumerable<TaskColorDTO> GetAllColors()
        {
            return  _mapper
                .Map<IEnumerable<Entitites.TaskColor>, IEnumerable<TaskColorDTO>>
                (this.repository.GetAll());
             
        }
    }
}
