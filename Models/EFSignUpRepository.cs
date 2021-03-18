using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class EFSignUpRepository : ISignUpRepository
    {
        // Creating a property "context" of type "SignUpContext"
        private SignUpContext _context;

        // Constructor
        public EFSignUpRepository(SignUpContext context)
        {
            _context = context;
        }

        // Projects is being set to what is in the _context.Projects (set up in SignUpContext file)
        public IQueryable<SignUpModel> SignUps => _context.SignUps;
    }
}
