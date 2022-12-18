using HomeWork.Data.Data;
using HomeWork.Data.Repositories.ConcreteTypeRepositories;
using JFA.DependencyInjection;

namespace HomeWork.Data.Repositories;

[Scoped]
public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }


    private IGroupRepository _groupRepository;
    public IGroupRepository Groups
    {
        get
        {
            if (_groupRepository is null) _groupRepository = new GroupRepository(_context);
            return _groupRepository;
        }
    }

    private ITaskRepository _taskRepository;
    public ITaskRepository Tasks
    {
        get
        {
            if(_taskRepository is null) _taskRepository = new TaskRepository(_context);
            return _taskRepository;
        }
    }

    private ITaskCommentRepository _taskComments;
    public ITaskCommentRepository TaskComments
    {
        get
        {
            if(_taskComments is null) _taskComments = new TaskCommentRepository(_context);
            return _taskComments;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }
    public int Save() => _context.SaveChanges();
}
