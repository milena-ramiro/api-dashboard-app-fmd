using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Dashboard.Api.Controllers.Shared;
using Dashboard.Business.ViewModels;
using Dashboard.Business.Interfaces;
using Dashboard.Business.Interfaces.Repository;
using Dashboard.Business.Models;

namespace Dashboard.Api.Controllers
{
    [Route("api/team")]
    public class TeamController : MainController
    {
        private readonly ITeamRepository _repository;

        public TeamController(INotificator notificator, ITeamRepository repository) : base(notificator)
        {
            _repository = repository;
        }

        // GET: TeamController
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _repository.Get();
            var teamsViewModel = response.Select(t => new TeamViewModel(t)).ToList();
            return CustomResponse(teamsViewModel);
        }

        // POST: TeamController/Create
        [HttpPost("create")]
        public async Task<IActionResult> Post(TeamCreateViewModel model)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var team = new Team(model);
            await _repository.Add(team);
            return CustomResponse(model);
        }

        
        // POST: TeamController/Delete/5
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var team = await _repository.GetById(id);

            if (team == null) return NotFound();

            await _repository.Remove(id);
            return CustomResponse(new TeamViewModel(team));
        }
    }
}
