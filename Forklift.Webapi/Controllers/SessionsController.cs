using System;
using System.Threading.Tasks;
using Forklift.Webapi.Domain;
using Forklift.Webapi.InputModels;
using Forklift.Webapi.Repositories;
using Forklift.Webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Forklift.Webapi.Controllers
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

        /// <summary>
        /// Cria uma seção do algorítmo genético
        /// </summary>
        /// <param name="inputModel">Parâmetros da seção</param>
        /// <returns></returns>
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

        /// <summary>
        /// Avança um determinado número de gerações para uma determinada seção
        /// </summary>
        /// <param name="id">Id da seção</param>
        /// <param name="inputModel">Parâmetros das gerações</param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public Task<ActionResult<GenerationsViewModel>> AdvanceGenerationsAsync(Guid id, [FromBody] ForewardGenerationsInputModel inputModel = null)
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