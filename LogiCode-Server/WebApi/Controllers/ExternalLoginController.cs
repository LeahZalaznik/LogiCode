    using Microsoft.AspNetCore.Mvc;
using Service.Repositories;

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
    public async Task<IActionResult> LoginWithGoogle([FromBody] string idToken)
    {
        try
        {
            var user = await _userService.AuthenticateWithGoogleAsync(idToken);
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
}
