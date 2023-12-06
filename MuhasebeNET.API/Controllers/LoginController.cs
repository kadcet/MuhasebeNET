using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MuhasebeNET.App;
using MuhasebeNET.Domain.Entities;

namespace MuhasebeNET.API.Controllers
{


	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		[HttpPost]
		[Route("GetAllUser")]
		public IActionResult GetAllUser([FromForm] string usernameInput, [FromForm] string passwordInput)
		{
			User_ user_ = new User_();
			user_.UserName = usernameInput;
			user_.Password = passwordInput;
			return Ok();
		}
	}
}
