using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;

namespace HomeWork.BLL.Interfaces;
public interface ITaskService
{
    Task<List<TaskViewModel>> GetAllTasksAsync();
    Task<TaskViewModel> GetTasksByIdAsync(Guid taskId);
    Task DeleteTaskAsync(Guid taskId);
    Task AddTaskAsync(CreateTaskDto createTaskDto);
    Task UpdateTaskAsync(Guid taskId,UpdateTaskDto updateTaskDto);
}
