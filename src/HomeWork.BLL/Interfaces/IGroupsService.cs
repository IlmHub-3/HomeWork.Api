using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;

namespace HomeWork.BLL.Interfaces;

public interface IGroupsService
{
    Task AddGroupAsync(CreateGroupDto createGroupDto);
    Task<List<GroupViewModel>> GetGroupsAsync();
    Task<GroupViewModel> GetGroupByIdAsync(Guid groupId);
    Task UpdateGroupAsync(Guid groupId);
    Task DeletGroupAsync(Guid groupId);
}
