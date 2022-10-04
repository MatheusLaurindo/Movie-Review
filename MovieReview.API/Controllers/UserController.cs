using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieReview.API.Services.Interfaces;
using MoviewReview.Core.Domain.Entities;
using MoviewReview.Core.Services.Interfaces;

namespace MovieReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserService _userService;

        public UserController(ITokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetAll")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _userService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                var result = await _userService.GetByIdAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync([FromBody] User user)
        {
            try
            {
                await _userService.AddAsync(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAsync([FromBody] User user)
        {
            try
            {
                await _userService.UpdateAsync(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _userService.DeleteByIdAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> LoginAsync([FromBody] User user)
        {
            try
            {
                var userResult = await _userService.GetByNameAndPasswordAsync(user.Name, user.Password);

                if (user == null)
                {
                    return NotFound(new {message = "User not found."});
                }

                var token = _tokenService.GenerateToken(user);

                Dictionary<string, string> userToken = new Dictionary<string, string>();
                userToken.Add(user.Name, token);

                return Ok(userToken);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
