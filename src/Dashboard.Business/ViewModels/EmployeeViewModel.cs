using System;
using System.ComponentModel.DataAnnotations;
using Dashboard.Business.Models;

namespace Dashboard.Business.ViewModels
{
    public class EmployeeCreateViewModel
    {
        public EmployeeCreateViewModel()
        {
            
        }

        public EmployeeCreateViewModel(Employee employee)
        {
            TeamId = Guid.Empty;
            Name = employee.Name;
            Gender = employee.Gender;
            Discord = employee.Discord;
            Whatsapp = employee.Whatsapp;
            Email = employee.Email;
        }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid TeamId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Discord { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Whatsapp { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }
    }

    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            
        }

        public EmployeeViewModel(Employee employee)
        {
            Name = employee.Name;
            Gender = employee.Gender;
            Discord = employee.Discord;
            Whatsapp = employee.Whatsapp;
            Email = employee.Email;
        }
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Discord { get; set; }

        public string Whatsapp { get; set; }

        public string Email { get; set; }
    }
}
