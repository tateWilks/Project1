using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class AvailableTimes
    {
        // Have a value set to booked? when a time has been booked?

        // Properties
        public TimeSpan EightAM { get; set; }
        public TimeSpan NineAM { get; set; }
        public TimeSpan TenAM { get; set; }
        public TimeSpan ElevenAM { get; set; }
        public TimeSpan TwelvePM { get; set; }
        public TimeSpan OnePM { get; set; }
        public TimeSpan TwoPM { get; set; }
        public TimeSpan ThreePM { get; set; }
        public TimeSpan FourPM { get; set; }
        public TimeSpan FivePM { get; set; }
        public TimeSpan SixPM { get; set; }
        public TimeSpan SevenPM { get; set; }
        public TimeSpan EightPM { get; set; }


        // Constructor
        public AvailableTimes()
        {
            EightAM = new DateTime(2021, 3, 16, 8, 0, 0).TimeOfDay;
            NineAM = new DateTime(2021, 3, 16, 9, 0, 0).TimeOfDay;
            TenAM = new DateTime(2021, 3, 16, 10, 0, 0).TimeOfDay;
            ElevenAM = new DateTime(2021, 3, 16, 11, 0, 0).TimeOfDay;
            TwelvePM = new DateTime(2021, 3, 16, 12, 0, 0).TimeOfDay;
            OnePM = new DateTime(2021, 3, 16, 13, 0, 0).TimeOfDay;
            TwoPM = new DateTime(2021, 3, 16, 14, 0, 0).TimeOfDay;
            ThreePM = new DateTime(2021, 3, 16, 15, 0, 0).TimeOfDay;
            FourPM = new DateTime(2021, 3, 16, 16, 0, 0).TimeOfDay;
            FivePM = new DateTime(2021, 3, 16, 17, 0, 0).TimeOfDay;
            SixPM = new DateTime(2021, 3, 16, 18, 0, 0).TimeOfDay;
            SevenPM = new DateTime(2021, 3, 16, 19, 0, 0).TimeOfDay;
            EightPM = new DateTime(2021, 3, 16, 20, 0, 0).TimeOfDay;
        }
    }
}
