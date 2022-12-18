using HomeWork.Data.Data;
using HomeWork.Data.Entities;

namespace HomeWork.Data.Repositories.ConcreteTypeRepositories;
public class TaskCommentRepository : GenericRepository<TaskComment>, ITaskCommentRepository
{
    public TaskCommentRepository(AppDbContext context) : base(context) { }
}
