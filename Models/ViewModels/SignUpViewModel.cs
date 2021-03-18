using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models.ViewModels
{
    public class SignUpViewModel
    {
        public IEnumerable<SignUpModel> SignUps { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
