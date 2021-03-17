using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class SignUpModel
    {
		// Properties
		[Key]
		[Required]
		public int groupId { get; set; }
		[Required]
		public string groupName { get; set; }
		[Required]
		public string groupSize { get; set; }
		[Required]
		public string email { get; set; }
#nullable enable
		public string? phone { get; set; }

		// how is the availableTime property going to work here?
		// think I need to create a set and/or get method?
		// I don't know if we need this property here
		public DateTime availableTimes { get; set; }
	}
}
