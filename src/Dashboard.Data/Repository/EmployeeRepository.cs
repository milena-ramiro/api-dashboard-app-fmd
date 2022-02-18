using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard.Business.Interfaces.Repository;
using Dashboard.Business.Models;
using Dashboard.Business.ViewModels;
using Dashboard.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data.Repository;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(AppDbContext db) : base(db)
    {
    }

    public async Task<List<EmployeeViewModel>> GetByTeam(int idTeam)
    {
        var response = await DbSet.AsNoTracking()
            .Where(e => e.TeamId.Equals(idTeam))
            .ToListAsync();

        return response.Select(e => new EmployeeViewModel(e)).ToList();
    }
}