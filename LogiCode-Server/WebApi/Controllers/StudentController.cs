using Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpPost("google")]
        public async Task<IActionResult> LoginWithGoogle([FromBody] TokenDto Token)
        {
            try
            {
                var user = await _studentService.AuthenticateWithGoogleAsync(Token.Token);
                return Ok(user); // בעתיד אפשר גם להחזיר JWT
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("s")]
        public async Task<IActionResult> LoginWithPasswordAsync([FromBody] string password)
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

        [HttpPost("Login")]
        public async Task<IActionResult> addStudentAsync([FromBody] Student user)
        {
            try
            {
                var re = await _studentService.addAsync(user);
                return Ok(re);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



    }
}
