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
        // each dbset is a table in the database
        // Properties
        public DbSet<SignUpModel> SignUps { get; set; }
        public DbSet<AvailableTimes> availableTimes { get; set; }
        // when setting the availabletime the view should take teh value frmo the other view
    }
}
