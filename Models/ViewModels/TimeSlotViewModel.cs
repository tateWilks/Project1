using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models.ViewModels
{
    public class TimeSlotViewModel
    {
        public IEnumerable<TimeSlot> TimeSlots { get; set; }
        public PagingInfo PagingInfo { get; set; }        
    }
}
