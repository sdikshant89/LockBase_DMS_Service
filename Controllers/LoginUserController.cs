using System;
using LockBase_DMS_Service.Interfaces;
using LockBase_DMS_Service.Model;
using Microsoft.AspNetCore.Mvc;

namespace LockBase_DMS_Service.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class LoginUserController : Controller
	{
        private readonly ILoginUserRepository _iloginUserRepository;

        public LoginUserController(ILoginUserRepository iloginUserRepository)
		{
            this._iloginUserRepository = iloginUserRepository;
        }

		[HttpGet]
		[ProducesResponseType(200, Type=typeof(IEnumerable<LoginUser>))]
		public IActionResult GetLoginUsers()
		{
			var LoginUsers = _iloginUserRepository.GetLoginUsers();

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			return Ok(LoginUsers);
		}
	}
}

