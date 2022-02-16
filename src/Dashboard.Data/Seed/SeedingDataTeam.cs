using System;
using Dashboard.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data.Seed
{
    public static class SeedingDataTeam
    {
        public static void SeedTeam(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Theme = "primary",
                    Title = "Frontend"
                },
                new Team
                {
                    Id = 2,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Theme = "danger", Title = "Backend"
                },
                new Team
                {
                    Id = 3,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Theme = "warning", Title = "Design"
                },
                new Team
                {
                    Id = 4,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                    Theme = "secondary", Title = "Comercial"
                }
            );
        }
    }
}