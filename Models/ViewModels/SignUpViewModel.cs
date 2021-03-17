using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models.ViewModels
{
    public class SignUpViewModel
    {
        public IEnumerable<SignUpModel> SignUps { get; set; }
        public AvailableTimes AvailableTimes { get; set; }

        // in the controller, do what you did in the WaterProject
        // create new ProjectsListViewModel (w/ the linq stuff)
        // you can get the time passed in from the model
        // instead of using ViewModel, we could use the viewBag to bring in the chosen timeslot
    }
}
