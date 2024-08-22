
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
                var coleta = _coletasRepository.GetDenunciaConfirm();
                return Ok(denunciasConfirm);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDenunciasConfirmById(int id)
        {
            try
            {
                var denunciasConfirm = _denunciasConfirmRepository.GetDenunciaConfirmById(id);
                return Ok(denunciasConfirm);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertDenunciasConfirm(Bairro denunciasConfirm)
        {
            try
            {
                _denunciasConfirmRepository.InsertDenunciaConfirm(denunciasConfirm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateDenunciasConfirm(Bairro denunciasConfirm)
        {
            try
            {
                _denunciasConfirmRepository.UpdateDenunciaConfirm(denunciasConfirm);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDenunciasConfirm(int id)
        {
            try
            {
                _denunciasConfirmRepository.DeleteDenunciaConfirm(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
