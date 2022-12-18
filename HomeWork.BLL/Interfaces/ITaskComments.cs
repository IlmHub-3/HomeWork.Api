using HomeWork.BLL.Dtos;

namespace HomeWork.BLL.Interfaces;
internal interface ITaskComments
{
    Task AddTaskCommentsAsync(CreateTaskCommentDto createTaskCommentDto);
    Task GetTaskCommentsAsync();
    Task GetTaskCommentsByIdAsync(Guid taskId);
    Task DeleteTaskCommentsAsync(Guid taskId);
    Task UpdateTaskComments();
}
