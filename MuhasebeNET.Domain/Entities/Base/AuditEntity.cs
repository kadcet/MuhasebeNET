﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeNET.Domain.Entities.Base
{
	public abstract class AuditEntity:BaseEntity
	{
		public DateTime? CreatedDate { get; set; }

		public DateTime? UpdatedDate { get; set; }
	}
}
