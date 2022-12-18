using HomeWork.Data.Repositories.ConcreteTypeRepositories;

namespace HomeWork.Data.Repositories;

public interface IUnitOfWork
{
    IGroupRepository Groups { get; }
    ITaskCommentRepository TaskComments { get; }
    ITaskRepository Tasks { get; }
    int Save();
}