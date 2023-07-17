using Microsoft.AspNetCore.Mvc;
using Serilog;
using ToDo.BLL.DTO.TaskColor;
using ToDo.BLL.Services.TaskColor;

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
                Log.Information("The color start  getting");
                var tasks = taskColorService.GetAllColors();
                Log.Information("The color was getted");
                return Ok(tasks);
            }
            catch (Exception ex)
            {
                exText = ex.Message;
                Log.Error(ex.Message);
            }
            return BadRequest(exText);

        }
    }
}
