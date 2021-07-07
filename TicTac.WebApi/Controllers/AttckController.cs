using Microsoft.AspNetCore.Mvc;
using System;
using TicTac.Domain.Model;
using TicTac.Interfaces.Services;

namespace TicTac.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AttackController : ControllerBase
    {
        private IAttack _game;

        public AttackController(IAttack game) => _game = game;

        [HttpPost]
        public ActionResult Attack([FromHeader] string _id, string x, string y)
        {
            try
            {
                _game.PutSign(_id, x, y);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
