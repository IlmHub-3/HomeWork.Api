using HomeWork.Api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(List<UserView>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetCategories([FromQuery] PaginationParams paginationParams)
    {
        var categories = await _categoriesService.GetCategoriesAsync(paginationParams);

        return Ok(categories);
    }
}
