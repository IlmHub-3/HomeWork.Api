using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;

namespace HomeWork.BLL.Interfaces;
public interface ITasksService
{
    Task<List<TaskViewModel>> GetAllTasksAsync();
    Task<TaskViewModel> GetTaskByIdAsync(Guid taskId);
    Task DeleteTaskAsync(Guid taskId);
    Task AddTaskAsync(CreateTaskDto createTaskDto);
    Task UpdateTaskAsync(Guid taskId);  
}
