using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Form names used in SignUp.cshtml: availableTime, groupName, groupSize, email, phone

namespace Project1.Models
{
    public class SignUpModel
    {
		[Key]
		[Required]
		public int GroupId { get; set; }
		[Required]
		public string groupName { get; set; }
		[Required]
		public string groupSize { get; set; }
		[Required]
		public string Email { get; set; }
#nullable enable
		public string? Phone

		//public string availableTime { get; set; }
	}
}
