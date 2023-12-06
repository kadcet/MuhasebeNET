using MuhasebeNET.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeNET.App
{
	public interface IUserService
	{
		User_ UserAdded(User_ user);

		bool UserDeleted(int userid);

		bool UserDeleted(User_ userEntity);

		User_ UserUpdated(int userid, User_ user);
	}
}
