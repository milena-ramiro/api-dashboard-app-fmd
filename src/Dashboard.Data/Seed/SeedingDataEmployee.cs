using System;
using Dashboard.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data.Seed;

public static class SeedingDataEmployee
{
    public static void SeedEmployee(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1, TeamId = 1, Name = "Renan - Zica",
                Gender = "male", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 2, TeamId = 1, Name = "Vitão",
                Gender = "male", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 3, TeamId = 1, Name = "Camila",
                Gender = "female", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 4, TeamId = 1, Name = "Barba",
                Gender = "male", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 5, TeamId = 2, Name = "Milena",
                Gender = "female", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 6, TeamId = 2, Name = "Irineu",
                Gender = "male", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 7, TeamId = 3, Name = "Renatox",
                Gender = "male", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 8, TeamId = 3, Name = "Raelle",
                Gender = "female", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 9, TeamId = 4, Name = "Aaron Roger",
                Gender = "male", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            },
            new Employee
            {
                Id = 10, TeamId = 4, Name = "Lisa Simpson",
                Gender = "female", Discord = "https://www.google.com.br",
                Whatsapp = "https://www.google.com.br", Email = "https://www.google.com.br"
            }
        );
    }
}