using HomeWork.Data.Data;
using HomeWork.Data.Entities;

namespace HomeWork.Data.Repositories.ConcreteTypeRepositories;
public class TaskRepository : GenericRepository<TaskEntity>, ITaskRepository
{
    public TaskRepository(AppDbContext context) : base(context) { }
}
