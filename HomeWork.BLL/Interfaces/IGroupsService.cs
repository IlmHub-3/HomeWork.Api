using HomeWork.Data.ViewModels;

namespace HomeWork.BLL.Interfaces;

public interface IGroupsService
{
    Task<List<GroupViewModel>> GetGroupsAsync();
    Task<GroupViewModel> GetGroupByIdAsync(Guid groupId);
    Task UpdateGroupAsync(Guid groupId);
    Task DeletGroupAsync(Guid groupId);
}
