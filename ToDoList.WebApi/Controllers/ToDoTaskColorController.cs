using Microsoft.AspNetCore.Mvc;
using ToDo.BLL.DTO.TaskColor;
using ToDo.BLL.DTO.ToDoTask;
using ToDo.BLL.Services.TaskColor;
using ToDo.BLL.Services.ToDoTask;

namespace ToDoList.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ToDoTaskColorController : ControllerBase
    {
        ITaskColorService taskColorService;
        public ToDoTaskColorController(ITaskColorService service)
        {
            taskColorService = service;

        }

        [HttpGet]
        public ActionResult<IEnumerable<TaskColorDTO>> GetAll()
        {
            string exText;
            try
            {
                var tasks = taskColorService.GetAllColors();
                return Ok(tasks);
            }
            catch (Exception ex)
            {
                exText = ex.Message;
            }
            return BadRequest(exText);

        }
    }
}
