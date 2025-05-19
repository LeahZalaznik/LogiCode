using Core.DTO;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Repositories;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    private readonly ICourseService _courseService;
    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }
    [HttpGet()]
    public async Task<List<Course>> GetByUserAsync([FromBody] string userId)
    {
        try
        {
            List<Course> coursesOfUser = await _courseService.GetByUserAsync(userId);
            return coursesOfUser;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}


    

