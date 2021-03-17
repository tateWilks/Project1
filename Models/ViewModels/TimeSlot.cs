using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class TimeSlot
    {
        public DateTime DateTimeSlot { get; set; }
        #nullable enable
        public bool? IsAvailable { get; set; }

        public TimeSlot(DateTime date)
        {
            DateTimeSlot = date;
        }
    }
}
