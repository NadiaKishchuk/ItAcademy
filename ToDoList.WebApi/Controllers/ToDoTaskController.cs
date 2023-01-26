using Microsoft.AspNetCore.Mvc;
using ToDo.BLL.DTO.ToDoTask;
using ToDo.BLL.Services.ToDoTask;

namespace ToDoList.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ToDoTaskController : ControllerBase
    {
        IToDoTaskService toDoTaskService;
        public ToDoTaskController(IToDoTaskService service)
        {
            toDoTaskService = service;

        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDoTaskDTO>> GetAll()
        {
            string exText;
            try
            {
                var tasks = toDoTaskService.GetAllTasks();
                return Ok(tasks);
            }
            catch(Exception ex)
            {
                exText = ex.Message;
            }
            return BadRequest(exText);
           
        }
        [HttpPost]
        public ActionResult Add(NewToDoTask newTask)
        {
            string exText;
            try
            {
                toDoTaskService.Add(newTask);
                return Ok();
            }
            catch (Exception ex)
            {
                exText = ex.Message;
            }
            return BadRequest(exText);
        }
        [HttpPut]
        
        public ActionResult ChangeColor(int taskId, int newColorId)
        {
            string exText;
            try
            {
                toDoTaskService.ChangeColor(taskId, newColorId);
                return Ok();
            }
            catch (Exception ex)
            {
                exText = ex.Message;
            }
            return BadRequest(exText);
        }

        [HttpPut, Route("update")]
        public ActionResult Update([FromBody]ToDoTaskDTO updatedtask)
        {
            string exText;
            try
            {
                toDoTaskService.Update(updatedtask);
                return Ok();
            }
            catch (Exception ex)
            {
                exText = ex.Message;
            }
            return BadRequest(exText);
        }
        [HttpDelete]
        public ActionResult Delete(int taskId)
        {
            string exText;
            try
            {
                toDoTaskService.Remove(taskId);
                return Ok();
            }
            catch (Exception ex)
            {
                exText = ex.Message;
            }
            return BadRequest(exText);
        }



    }
}
