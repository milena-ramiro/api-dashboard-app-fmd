using System;
using System.ComponentModel.DataAnnotations.Schema;
using Dashboard.Business.ViewModels;

namespace Dashboard.Business.Models
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            
        }

        public Employee(EmployeeCreateViewModel employee)
        {
            Name = employee.Name;
            Gender = employee.Gender;
            Discord = employee.Discord;
            Whatsapp = employee.Whatsapp;
            Email = employee.Email;
            TeamId = employee.TeamId;
        }

        [Column("TeamId")]
        public Guid TeamId { get; set; }
        public virtual Team Team { get; set; }


        [Column("Name")]
        public string Name { get; set; }

        [Column("Gender")]
        public string Gender { get; set; }

        [Column("Discord")]
        public string Discord { get; set; }

        [Column("Whatsapp")]
        public string Whatsapp { get; set; }

        [Column("Email")]
        public string Email { get; set; }
        
    }
}
