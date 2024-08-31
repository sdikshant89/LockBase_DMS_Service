using System;
using LockBase_DMS_Service.Data;
using LockBase_DMS_Service.Interfaces;
using LockBase_DMS_Service.Model;

namespace LockBase_DMS_Service.Repository
{
	public class LoginUserRepository : ILoginUserRepository
	{
		public readonly DataContext _context;

		public LoginUserRepository(DataContext context)
		{
			_context = context;
		}

		public ICollection<LoginUser> GetLoginUsers()
		{
			return _context.LoginUsers.OrderBy(p => p.Id).ToList();
		}
	}
}