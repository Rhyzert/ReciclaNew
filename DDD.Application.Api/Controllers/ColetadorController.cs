
using ApplicationService.Interface;
using DDD.Domain.ReportRadarContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ColetadorController : ControllerBase
    {
        readonly IColetadorApplication _coletadorRepository;

        public ColetadorController(IColetadorApplication coletadorRepository)
        {
            _coletadorRepository = coletadorRepository;
        }

        [HttpGet]
        public IActionResult GetColetador()
        {
            try
            {
                var coletador = _coletadorRepository.GetColetadores();
                return Ok(coletador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetColetadors(int id)
        {
            try
            {
                var coletador = _coletadorRepository.GetColetador(id);
                return Ok(coletador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertColetador(Coletador coletador)
        {
            try
            {
                _coletadorRepository.InsertColetador(coletador);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateColetador(Coletador coletador)
        {
            try
            {
                _coletadorRepository.UpdateColetador(coletador);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteColetador(int id)
        {
            try
            {
                _coletadorRepository.DeleteColetador(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
