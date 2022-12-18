using HomeWork.BLL.Dtos;
using HomeWork.BLL.Interfaces;
using HomeWork.BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
[Authorize(Policy = "TeacherRights")]
public class TeachersController : ControllerBase
{
    private readonly ITasksService _taskService;
    public TeachersController(ITasksService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<TaskViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllTasks()
    {
        var tasks = await _taskService.GetAllTasksAsync();
        return Ok(tasks);
    }

    [HttpGet("taskId:Guid")]
    public async Task<IActionResult> GetTaskByIdAsync(Guid taskId)
    {
        var task = await _taskService.GetTaskByIdAsync(taskId);
        return Ok(task);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTaskAsync([FromForm]CreateTaskDto createTaskDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        await _taskService.AddTaskAsync(createTaskDto);

        return Ok();
    }

    [HttpPut("taskId:Guid")]
    public async Task<IActionResult> UpdateTask(Guid taskId, UpdateTaskDto updateTaskDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        await _taskService.UpdateTaskAsync(taskId, updateTaskDto);

        return Ok();
    }

    [HttpDelete("taskId:Guid")]
    public async Task<IActionResult> DeleteTask(Guid taskId)
    {
        await _taskService.DeleteTaskAsync(taskId);
        return Ok();
    }
}
