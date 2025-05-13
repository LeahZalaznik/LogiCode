using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.c;
using Service.Interfaces;
using Service.Repositories;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService userService) 
        {
            _studentService = userService;
        }
        [HttpPost("google")]
        public async Task<IActionResult> LoginWithGoogle([FromBody] string idToken)
        {
            try
            {
                var user = await _studentService.AuthenticateWithGoogleAsync(idToken);
                return Ok(user); // בעתיד אפשר גם להחזיר JWT
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("")]
        public async Task<IActionResult> LoginWithPassword([FromBody] string password)
        {
            try
            {
                var user = await _studentService.GetByPasswordAsync(password);
                return Ok(user); // בעתיד אפשר גם להחזיר JWT
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
