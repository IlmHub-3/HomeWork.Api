using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.BLL.Dtos;
public class CreateTaskDto
{
    [Required]
    public string? Title { get; set; }
    public string? Description { get; set; }
    public ICollection<IFormFile>? Files { get; set; }
}
