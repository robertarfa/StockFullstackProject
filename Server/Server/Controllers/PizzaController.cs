using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Models;
using Server.Repositories;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;
        private readonly IPizzaRepository _repository;

        public PizzaController(ILogger<PizzaController> logger, IPizzaRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }


        [HttpGet(Name = "Get")]
        public ActionResult<IEnumerable<Pizza>> Get()
        {
            var all = _repository.GetAll();

            return Ok(all);
        }
    }
}
