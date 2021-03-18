using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class AvailableTimes
    {
        // Properties
        [Key]
        [Required]
        public int TimeId { get; set; }
        [Required]
        public DateTime SelectedDate { get; set; }
        [Required]
        public TimeSpan SelectTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}
