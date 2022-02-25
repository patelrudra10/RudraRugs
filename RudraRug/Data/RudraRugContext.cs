using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RudraRug.Models;

namespace RudraRug.Data
{
    public class RudraRugContext : DbContext
    {
        public RudraRugContext (DbContextOptions<RudraRugContext> options)
            : base(options)
        {
        }

        public DbSet<RudraRug.Models.Rug> Rug { get; set; }
    }
}
