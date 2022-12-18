using System.ComponentModel.DataAnnotations;

namespace HomeWork.BLL.ViewModels;
public class UserViewModel
{
    [Required]
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}
