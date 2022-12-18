using HomeWork.BLL.Interfaces;
using HomeWork.Data.Repositories;
using HomeWork.Data.ViewModels;
using JFA.DependencyInjection;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.BLL;

[Scoped]
public class GroupsService : IGroupsService
{
    private readonly IUnitOfWork _unitOfWork;
    public GroupsService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task DeletGroupAsync(Guid groupId)
    {
        var group = _unitOfWork.Groups.GetAll()
            .FirstOrDefault(g => g.Id == groupId);

        if (group is null)
            throw new();

        await _unitOfWork.Groups.Remove(group!);
    }

    public async Task<GroupViewModel> GetGroupByIdAsync(Guid groupId)
    {             
        var group = await _unitOfWork.Groups.GetAll().FirstOrDefaultAsync(group => group.Id == groupId);

        if (group is null)
            throw new();

        return group.Adapt<GroupViewModel>();
    }

    public async Task<List<GroupViewModel>> GetGroupsAsync()
    {
        return (await _unitOfWork.Groups.GetAll().ToListAsync()).Adapt<List<GroupViewModel>>();
    }

    public async Task UpdateGroupAsync(Guid groupId)
    {
        var group = _unitOfWork.Groups.GetById(groupId);

        if (group == null)
            throw new();
        
       await _unitOfWork.Groups.Update(group);
    }
}
