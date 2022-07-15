using Microsoft.EntityFrameworkCore;
using System;
using Manchester_United_Squad_Library.Models;

namespace Manchester_United_Squad_Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {

        }
        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<Stats> Stats { get; set; }


    }

}
