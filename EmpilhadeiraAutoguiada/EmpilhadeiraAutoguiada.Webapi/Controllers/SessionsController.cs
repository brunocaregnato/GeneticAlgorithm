using System;
using System.Threading.Tasks;
using EmpilhadeiraAutoguiada.Webapi.Domain;
using EmpilhadeiraAutoguiada.Webapi.InputModels;
using EmpilhadeiraAutoguiada.Webapi.Repositories;
using EmpilhadeiraAutoguiada.Webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmpilhadeiraAutoguiada.Webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionsController : ControllerBase
    {
        private SessionsRepository _repository;

        public SessionsController(SessionsRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public Task<ActionResult<SessionViewModel>> CreateSessionAsync([FromBody] SessionInputModel inputModel)
            => Task.Run<ActionResult<SessionViewModel>>(() =>
            {
                var session = (Session) inputModel;

                if (session == null)
                    return BadRequest();

                _repository.AddSession(session);
                return Ok((SessionViewModel) session);
            });

        [HttpPost("{id}")]
        public Task<ActionResult<GenerationsViewModel>> CreateSessionAsync(Guid id, [FromBody] ForewardGenerationsInputModel inputModel = null)
            => Task.Run<ActionResult<GenerationsViewModel>>(() =>
            {
                var session = _repository.GetSession(id);

                if (session == null)
                    return NotFound();

                if (!session.IsActive)
                    return BadRequest();

                var viewModel = session.AdvanceGenerations(inputModel?.GenerationsCount ?? 200);
                return Ok(viewModel);
            });
    }
}