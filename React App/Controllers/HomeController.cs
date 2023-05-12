using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using React_App.Services;

namespace React_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Example Controller to handle request from home component.
        /// </summary>
        /// <param name="userService"> injection user service</param>
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// GET Method to get the initial values for the home component
        /// </summary>
        /// <param name="identifier"> user identifier</param>
        /// <returns>response format API</returns>
        [HttpGet]
        [Route("GetInitialData/{identifier?}")]
        public async Task<IResult?> GetInitialData(string? identifier)
        {
            var response = await _userService.GetUserByIdentifier(identifier);

            return response is not null 
                ? Results.Ok(new { user = response })
                : Results.NotFound(new { message = $"User with identifier {identifier} not found." });
        }
    }
}
