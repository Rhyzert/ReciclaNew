
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        readonly ICidadeRepository _cidadeRepository;

        public CidadeController(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Cidade>> Get()
        {
            return Ok(_cidadeRepository.GetCidades());
        }

        [HttpGet("{id}")]
        public ActionResult<Cidade> GetById(int id)
        {
            return Ok(_cidadeRepository.GetCidade(id));
        }

    }
}
