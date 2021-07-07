using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTac.Domain.Model;
using TicTac.Interfaces.Services;

namespace TicTac.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StateController : ControllerBase
    {
        private IState _state;
        public StateController(IState state) => _state = state;

        [HttpGet]
        public ActionResult<Game> GetGameState([FromHeader]string _gameId)
        {
            try
            {
                return Ok(_state.GetGameState(_gameId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }
    }
}
