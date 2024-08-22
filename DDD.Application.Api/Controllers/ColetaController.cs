
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
    public class ColetaController : ControllerBase
    {
        readonly IColetaApplication _coletasRepository;

        public ColetaController(IColetaApplication coletasRepository)
        {
            _coletasRepository = coletasRepository;
        }

        [HttpGet]
        public IActionResult GetColeta()
        {
            try
            {
                var coleta = _coletasRepository.GetColetas();
                return Ok(coleta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetColetas(int id)
        {
            try
            {
                var coleta = _coletasRepository.GetColeta(id);
                return Ok(coleta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertColeta(Coleta coleta)
        {
            try
            {
                _coletasRepository.InsertColeta(coleta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateColeta(Coleta coleta)
        {
            try
            {
                _coletasRepository.UpdateColeta(coleta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteColeta(int id)
        {
            try
            {
                _coletasRepository.DeleteColeta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
