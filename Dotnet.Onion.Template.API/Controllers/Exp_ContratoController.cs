using Dotnet.Onion.Template.API.DTO.Contrato;
using Dotnet.Onion.Template.Domain.Services.ContratoExp;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using Microsoft.IdentityModel.Tokens;
using Dotnet.Onion.Template.API.Utils;

namespace Dotnet.Onion.Template.API.Controllers
{
    [Route("api/dados-contrato")]
    [ApiController]
    public class Exp_ContratoController : ControllerBase
    {
        private readonly IExpContratoService _service;

        public Exp_ContratoController(IExpContratoService service)
        {
            _service = service;
        }


        /// <summary>
        /// Método para obter os dados referentes ao contrato => pg: Editar Contrato (GET)
        /// </summary>
        /// <returns>Lista contendo os dados do contrato informado</returns>
        [HttpGet]
        public IActionResult GetDadosContratoExpForUpdate(long handle)
        {
            try
            {
                if (handle == 0 || handle.ToString() == "")
                {
                    return BadRequest("É obrigatório informar um código de contrato válido!");
                }

                List<Exp_ContratoDTO> dadosContrato = _service.GetDadosContratoExpForUpdate(handle);

                if (dadosContrato.IsNullOrEmpty())
                {
                    return NotFound("Contrato informado não encontrado!");
                }

                return Ok(new CustomResponse<List<Exp_ContratoDTO>>(true, "Dados do contrato encontrados com sucesso!", dadosContrato));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro ao processar a solicitação: " + ex.Message);
            }
        }


    }
}
