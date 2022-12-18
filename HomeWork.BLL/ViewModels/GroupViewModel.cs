namespace HomeWork.BLL.ViewModels;

public class GroupViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Key { get; set; }
    public List<UserViewModel> Users { get; set; }

}
