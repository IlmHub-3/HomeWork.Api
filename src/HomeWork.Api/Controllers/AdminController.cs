using HomeWork.BLL.Dtos;
using HomeWork.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{

    [HttpGet]
    [ProducesResponseType(typeof(List<UserViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsersAsync([FromQuery] UsersFilterDto filterDto)
    {
        return Ok();
    }

    [HttpGet("{groupId:Guid}")]
    [ProducesResponseType(typeof(GroupViewModel), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCategoryById(Guid groupId)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateCategory(CreateGroupDto groupDto)
    {
        return Ok();
    }

    [HttpPut("{groupId:Guid}")]
    public async Task<IActionResult> UpdateCategory(Guid groupId, UpdateGroupDto updateGroupDto)
    {
        return Ok();
    }

    [HttpDelete("{groupId:Guid}")]
    public async Task<IActionResult> DeleteCategory(Guid groupId)
    {
        return Ok();
    }
}

