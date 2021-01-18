using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Hackathon.WebApi.Domains;
using Hackathon.WebApi.Interfaces;
using Hackathon.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private ICandidatoRepository _candidatoRepository { get; set; }

        public CandidatoController()
        {
            _candidatoRepository = new CandidatoRepository();
        }

        
        [Authorize(Roles = "2")]
        [HttpPut("AtualizarCandidato")]
        public IActionResult AtualizarCandidato(Candidato candidato)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Candidato candidatoBuscado = _candidatoRepository.BuscarCandidatoPorIdUsuario(idUsuario);
                if (candidatoBuscado == null)
                    return BadRequest();

                if (_candidatoRepository.AtualizarCandidato(idUsuario, candidato))
                    return Ok();
                else
                    return BadRequest();
            }
            catch
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize(Roles = "2")]
        [HttpPost("AdicionarInscricao")]
        public IActionResult AdicionarInscricao(Inscricao InscricaoNovo)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Candidato candidatoBuscado = _candidatoRepository.BuscarCandidatoPorIdUsuario(idUsuario);
                if (candidatoBuscado == null)
                    return BadRequest();

                InscricaoNovo.IdCandidato = candidatoBuscado.IdCandidato;
                if (_candidatoRepository.SeInscrever(InscricaoNovo))
                    return Ok("Inscricao cadastrada com sucesso");
                else
                    return BadRequest("Não foi possivel cadastrar a inscricao");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "2")]
        [HttpDelete("RevogarInscricao/{idInscricao}")]
        public IActionResult DeletarInscricao(int idInscricao)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Candidato candidatoBuscado = _candidatoRepository.BuscarCandidatoPorIdUsuario(idUsuario);
                if (candidatoBuscado == null)
                    return BadRequest();

                if (_candidatoRepository.RevogarInscricao(idInscricao, candidatoBuscado.IdCandidato))
                    return Ok("Inscricao deletada com sucesso");
                else
                    return BadRequest("Não foi possivel deletar o Inscricao");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "2")]
        [HttpGet("ListarVagasInscritas")]
        public IActionResult ListarVagasInscritas()
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                return Ok(_candidatoRepository.ListarInscricoes(idUsuario));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize(Roles = "2")]
        [HttpGet("ListarVagasPrincipal/{idArea}")]
        public IActionResult ListarVagasPrincipal(int idArea)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                return Ok(_candidatoRepository.ListarVagasArea(idArea));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize(Roles = "2")]
        [HttpGet("BuscarCandidatoPorId")]
        public IActionResult BuscarCandidatoPorId()
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                return Ok(_candidatoRepository.BuscarCandidatoPorIdUsuario(idUsuario));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }
    }
}