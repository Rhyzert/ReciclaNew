
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
    public class LixoController : ControllerBase
    {
        readonly ILixoApplication _lixosRepository;

        public LixoController(ILixoApplication lixosRepository)
        {
            _lixosRepository = lixosRepository;
        }

        [HttpGet]
        public IActionResult GetLixo()
        {
            try
            {
                var lixo = _lixosRepository.GetLixos();
                return Ok(lixo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetLixos(int id)
        {
            try
            {
                var lixo = _lixosRepository.GetLixo(id);
                return Ok(lixo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertLixo(Lixo lixo)
        {
            try
            {
                _lixosRepository.InsertLixo(lixo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateLixo(Lixo lixo)
        {
            try
            {
                _lixosRepository.UpdateLixo(lixo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLixo(int id)
        {
            try
            {
                _lixosRepository.DeleteLixo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
