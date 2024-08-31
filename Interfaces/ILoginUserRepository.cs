using System;
using LockBase_DMS_Service.Model;

namespace LockBase_DMS_Service.Interfaces
{
	public interface ILoginUserRepository
	{
		ICollection<LoginUser> GetLoginUsers();
	}
}