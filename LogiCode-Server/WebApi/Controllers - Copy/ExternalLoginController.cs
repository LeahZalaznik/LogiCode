using Microsoft.AspNetCore.Mvc;
using Service.Repositories;
using Core.DTO;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("google")]
    public async Task<IActionResult> LoginWithGoogle([FromBody] TokenDto Token)
    {
        try
        {
            var user = await _userService.AuthenticateWithGoogleAsync(Token.Token);
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
            var user = await _userService.GetByPasswordAsync(password);
            return Ok(user); // בעתיד אפשר גם להחזיר JWT
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    //[HttpDelete("")]
    //public async Task<IActionResult> delAsync(int id)
    //{
    //    return Ok();
    //}
}
