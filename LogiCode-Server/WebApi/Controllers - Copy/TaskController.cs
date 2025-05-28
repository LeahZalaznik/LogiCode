using Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using myTask = Core.DTO.MyTask;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<myTask>>> GetAll()
        {
            var tasks = await _taskService.GetAllAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<myTask>> GetById(int id)
        {
            var task = await _taskService.GetByIdAsync(id);
            if (task == null)
                return NotFound();
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<Task>> Add(myTask task)
        {
            var added = await _taskService.AddAsync(task);
            return CreatedAtAction(nameof(GetById), new { id = added.Id }, added);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, myTask task)
        {
            if (id != task.Id)
                return BadRequest();

            var updated = await _taskService.UpdateAsync(task);
            if (updated == null)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _taskService.DeleteAsync(id);
            if (deleted == null)
                return NotFound();

            return NoContent();
        }
    }
}
