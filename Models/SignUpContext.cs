using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class SignUpContext : DbContext
    {
        // Constructor
        public SignUpContext (DbContextOptions<SignUpContext> options) : base (options)
        {

        }

        // Properties
        public DbSet<SignUpModel> SignUps { get; set; }
    }
}
