using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Dashboard.Business.ViewModels;

namespace Dashboard.Business.Models;

public class Team : BaseEntity
{
    public Team()
    {
    }

    public Team(TeamCreateViewModel team)
    {
        Title = team.Title;
        Description = team.Description;
        Theme = team.Theme;
    }

    [Column("Title")] public string Title { get; set; }

    [Column("Description")] public string Description { get; set; }

    [Column("Theme")] public string Theme { get; set; }

    public virtual ICollection<Employee> Employees { get; set; }
}