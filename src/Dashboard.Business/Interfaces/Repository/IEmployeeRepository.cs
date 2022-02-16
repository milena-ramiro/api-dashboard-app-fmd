using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Business.Models;
using Dashboard.Business.ViewModels;

namespace Dashboard.Business.Interfaces.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<List<EmployeeViewModel>> GetByTeam(int idTeam);
    }
}
