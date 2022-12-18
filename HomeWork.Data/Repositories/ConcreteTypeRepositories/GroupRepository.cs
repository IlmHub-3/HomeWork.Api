using HomeWork.Data.Data;
using HomeWork.Data.Entities;

namespace HomeWork.Data.Repositories.ConcreteTypeRepositories;
public class GroupRepository : GenericRepository<Group>, IGroupRepository
{
    public GroupRepository(AppDbContext context) : base(context) { }
}
