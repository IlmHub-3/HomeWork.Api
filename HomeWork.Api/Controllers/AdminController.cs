using HomeWork.BLL.Dtos;
using HomeWork.BLL.Interfaces;
using HomeWork.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    private readonly IGroupsService _groupsService;
    public AdminController(IGroupsService groupsService)
    {
        _groupsService = groupsService;
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<UserViewModel>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok();
    }

    [HttpGet("{groupId:guid}")]
    [ProducesResponseType(typeof(GroupViewModel), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetGroupById(Guid groupId)
    {
        await _groupsService.GetGroupByIdAsync(groupId);
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateGroup(CreateGroupDto groupDto)
    {
        await _groupsService.AddGroupAsync(groupDto);
        return Ok();
    }

    [HttpPut("{groupId:guid}")]
    public async Task<IActionResult> UpdateGroup(Guid groupId, UpdateGroupDto updateGroupDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        await _groupsService.UpdateGroupAsync(groupId,updateGroupDto);
        return Ok();
    }

    [HttpDelete("{groupId:guid}")]
    public async Task<IActionResult> DeleteGroup(Guid groupId)
    {
        await _groupsService.DeletGroupAsync(groupId);
        return Ok();
    }
}

