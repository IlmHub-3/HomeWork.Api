using HomeWork.BLL.Dtos;
using HomeWork.BLL.Interfaces;
using HomeWork.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StudentsController : ControllerBase
{
    private readonly ITasksService _tasksService;
    public StudentsController(ITasksService tasksService)
    {
        _tasksService = tasksService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<TaskViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllTasksAsync()
    {
        var tasks = await _tasksService.GetAllTasksAsync();
        return Ok(tasks);
    }

    [HttpGet("taskId:guid")]
    public async Task<IActionResult> GetTaskById(Guid taskId)
    {
        var task = await _tasksService.GetTaskByIdAsync(taskId);
        return Ok(task);
    }

    [HttpPut("taskId:guid")]
    public async Task<IActionResult> UpdateTask(Guid taskId, UpdateTaskDto updateTaskDto)
    {
        await _tasksService.UpdateTaskAsync(taskId, updateTaskDto);
        return Ok();
    }
}
