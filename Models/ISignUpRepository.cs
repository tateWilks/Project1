using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    // Interface template (not a class)
    public interface ISignUpRepository
    {
        IQueryable<SignUpModel> SignUps { get; }        
    }
}
