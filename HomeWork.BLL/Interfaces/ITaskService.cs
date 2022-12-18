using HomeWork.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.BLL.Interfaces;
public interface ITaskService
{
    Task<TaskViewModel> GetAllTasksAsync();
    Task<>
}
