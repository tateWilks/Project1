using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class EFSignUpRepository : ISignUpRepository
    {
        private SignUpContext _context;

        public EFSignUpRepository(SignUpContext context)
        {
            _context = context;
        }

        public IQueryable<SignUpModel> SignUps => _context.SignUps;
    }
}
