using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Dashboard.Business.Models;

namespace Dashboard.Business.ViewModels;

public class TeamViewModel
{
    public TeamViewModel()
    {
    }

    public TeamViewModel(Team team)
    {
        Id = team.Id;
        Title = team.Title;
        Description = team.Description;
        Theme = team.Theme;
    }

    public int Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Title { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Description { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Theme { get; set; }
}

public class TeamCreateViewModel
{
    public TeamCreateViewModel()
    {
    }

    public TeamCreateViewModel(Team team)
    {
        Title = team.Title;
        Description = team.Description;
        Theme = team.Theme;
    }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Title { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Description { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Theme { get; set; }
}