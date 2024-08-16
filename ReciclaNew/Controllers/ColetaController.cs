using Microsoft.AspNetCore.Mvc;
using ReciclaNew.Infrastructure;

namespace ReciclaNew.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColetaController : ControllerBase
    {
        private ReciclaNewDbContext _db;

        public ColetaController(ReciclaNewDbContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }


        [HttpGet]
        public IActionResult GetColeta()
        {
            var coletas = _db.Coletas.ToList(); 
            return Ok(coletas);
        }

        [HttpPost]
        public IActionResult AdicionaColeta(Coleta)
        {
            var coletas = _db.Coletas.Add();
            return Ok(coletas);
        }
    }
}
