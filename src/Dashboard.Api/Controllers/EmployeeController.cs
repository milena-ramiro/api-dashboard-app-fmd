using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dashboard.Api.Controllers.Shared;
using Dashboard.Business.ViewModels;
using Dashboard.Business.Interfaces;
using Dashboard.Business.Interfaces.Repository;
using Dashboard.Business.Models;

namespace Dashboard.Api.Controllers
{
    [Route("api/employee")]
    public class EmployeeController : MainController
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(INotificator notificator, IEmployeeRepository repository) : base(notificator)
        {
            _repository = repository;
        }
        
        // GET: TeamController
        [HttpGet]
        public async Task<IActionResult> Get(int teamId)
        {
            var response = await _repository.GetByTeam(teamId);
            return CustomResponse(response);
        }

        // POST: TeamController/Create
        [HttpPost("create")]
        public async Task<IActionResult> Post(EmployeeCreateViewModel model)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var team = new Employee(model);
            await _repository.Add(team);
            return CustomResponse(model);
        }
        
        // POST: TeamController/Delete/5
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _repository.GetById(id);

            if (employee == null) return NotFound();

            await _repository.Remove(id);
            return CustomResponse(new EmployeeViewModel(employee));
        }
    }
}
