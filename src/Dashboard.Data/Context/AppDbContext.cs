using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Employee> Employee { get; set; }

    }
}
