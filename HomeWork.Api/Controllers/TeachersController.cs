using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TeachersController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<TaskViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllTasksAsync([FromQuery] TaskFilterDto filterDto)
    {
        return Ok();
    }

    [HttpGet("taskId:Guid")]
    public async Task<IActionResult> GetTaskByIdAsync(Guid taskId)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateTaskAsync(CreateTaskDto createTaskDto)
    {
        return Ok();
    }

    [HttpPut("taskId:Guid")]
    public async Task<IActionResult> UpdateTask(Guid taskId, UpdateTaskDto updateTaskDto)
    {
        return Ok();
    }

    [HttpDelete("taskId:Guid")]
    public async Task<IActionResult> DeleteTask(Guid taskId)
    {
        return Ok();
    }
}
