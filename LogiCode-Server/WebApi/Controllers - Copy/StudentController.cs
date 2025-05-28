using Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAll()
        {

            var users = await _studentService.GetAllStudentsAsync();
            return Ok(users); // בעתיד אפשר גם להחזיר JWT
        }
        
        [HttpPost("google")]
        public async Task<IActionResult> LoginWithGoogleAsinc([FromBody] TokenDto Token)
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

        [HttpPut]
        public async Task<IActionResult> update([FromBody] Student user)
        {
            try
            {
                var re = await _studentService.UpdateAsync(user);
                return Ok(re);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
