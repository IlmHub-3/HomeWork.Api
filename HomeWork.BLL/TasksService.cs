using HomeWork.BLL.Dtos;
using HomeWork.BLL.Interfaces;
using HomeWork.BLL.ViewModels;
using HomeWork.Data.Entities;
using HomeWork.Data.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.BLL;

public class TasksService : ITasksService
{
    private readonly IUnitOfWork _unitOfWork;

    public TasksService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task AddTaskAsync(CreateTaskDto createTaskDto)
    {
        await _unitOfWork.Tasks.AddAsync(createTaskDto.Adapt<TaskEntity>());
    }

    public async Task DeleteTaskAsync(Guid taskId)
    {
        var task = await _unitOfWork.Tasks.GetAll().FirstOrDefaultAsync(task => task.Id == taskId);

        if (task is null)
            throw new();

        await _unitOfWork.Tasks.Remove(task);
    }

    public async Task<List<TaskViewModel>> GetAllTasksAsync()
    {
        return (await _unitOfWork.Tasks.GetAll().ToListAsync()).Adapt<List<TaskViewModel>>();
    }

    public async Task<TaskViewModel> GetTaskByIdAsync(Guid taskId)
    {
        var task = await _unitOfWork.Tasks.GetAll().FirstOrDefaultAsync(t => t.Id == taskId);

        if (task is null)
            throw new();

        return task.Adapt<TaskViewModel>();
    }

    public async Task UpdateTaskAsync(Guid taskId, UpdateTaskDto updateTaskDto)
    {
        var task = _unitOfWork.Tasks.GetAll().FirstOrDefault(t => t.Id == taskId);

        if (task is null)
            throw new();

        task.Title = updateTaskDto.Title;
        task.Description = updateTaskDto.Description;
        task.Status = updateTaskDto.Status!.Value;

        await _unitOfWork.Tasks.Update(task);
    }
}
