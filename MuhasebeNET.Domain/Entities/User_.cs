using MuhasebeNET.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeNET.Domain.Entities
{
	public class User_:AuditEntity
	{
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
