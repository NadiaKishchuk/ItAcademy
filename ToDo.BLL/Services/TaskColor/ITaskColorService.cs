using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.BLL.DTO.TaskColor;

namespace ToDo.BLL.Services.TaskColor
{
    public interface ITaskColorService
    {
        IEnumerable<TaskColorDTO> GetAllColors();
    }
}
