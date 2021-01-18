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
    public class EmpresaController : ControllerBase
    {
        private IEmpresaRepository _empresaIRepository { get; set; }

        public EmpresaController()
        {
            _empresaIRepository = new EmpresaRepository();
        }

        [HttpPut("AtualizarEmpresa")]
        public IActionResult AtualizarEmpresa(Empresa empresa)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                return Ok(_empresaIRepository.AtualizarEmpresaPorIdCorpo(idUsuario, empresa));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize(Roles = "3")]
        [HttpPost("AdicionarVaga")]
        public IActionResult AdicionarVaga(Vaga VagaNovo)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                VagaNovo.IdEmpresa = empresa.IdEmpresa;
                if (_empresaIRepository.AdicionarVaga(VagaNovo))
                    return Ok("Vaga cadastrado com sucesso");
                else
                    return BadRequest("Não foi possivel cadastrar a vaga,verifique se as informaçoes foram preenchidas corretamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        
        [Authorize(Roles = "3")]
        [HttpPost("AdicionarTecnologiaNaVaga")]
        public IActionResult AdicionarTecnologia(VagaTecnologia vagaTecnologia)
        {
            try
            {

                if (_empresaIRepository.AdicionarTecnologiaNaVaga(vagaTecnologia))
                    return Ok("Tecnologia adicionada com sucesso");
                else
                    return BadRequest("Não foi possivel cadastrar a tecnologia");
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
   
        [Authorize(Roles = "3")]
        [HttpDelete("DeletarVagaEmpresa/{idVaga}")]
        public IActionResult DeletarVaga(int idVaga)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                if (_empresaIRepository.DeletarVaga(idVaga))
                    return Ok("Vaga deletada com sucesso");
                else
                    return BadRequest("Não foi possivel cadastrar a Vaga");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [Authorize(Roles = "3")]
        [HttpPut("Aprovar/{idInscricao}")]
        public IActionResult AprovarCandidato(int idInscricao)
        {
            try
            {
                if (_empresaIRepository.AprovarCandidato(idInscricao))
                    return Ok("Candidato aprovado");
                else
                    return BadRequest("Erro ao aprovar esse candidato");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "3")]
        [HttpPut("Reprovar/{idInscricao}")]
        public IActionResult ReprovarCandidato(int idInscricao)
        {
            try
            {
                //Verificacao se a inscricao pertence a empresa
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                if (_empresaIRepository.ReprovarCandidato(idInscricao))
                    return Ok("Candidato reprovado");
                else
                    return BadRequest("Erro ao reprovar esse candidato");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Método que lista vagas que a empresa publicou
        /// </summary>
        /// <returns>Retorna lista de vagas publicadas</returns>
        [Authorize(Roles = "3")]
        [HttpGet("ListarVagasPublicadas")]
        public IActionResult ListarVagas()
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                return Ok(_empresaIRepository.ListarVagasDaEmpresa(empresa.IdEmpresa));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [Authorize(Roles = "3")]
        [HttpGet("ListarCandidatosInscritos/{idVaga}")]
        public IActionResult ListarCandidatosInscritos(int idVaga)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                return Ok(_empresaIRepository.ListarCandidatosInscritos(idVaga));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "3")]
        [HttpPut("AtualizarVagaEmpresa/{idVaga}")]
        public IActionResult AtualizarVaga(int idVaga, Vaga Vaga)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                if (_empresaIRepository.AtualizarVaga(idVaga, Vaga))
                    return Ok("Vaga atualizada com sucesso");
                else
                    return BadRequest("Não foi possivel atualizar");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Método que lista candidatos aprovados na vaga
        /// </summary>
        /// <param name="idVaga">Identificador da vaga</param>
        /// <returns>Retorna lista de candidatos aprovados</returns>
        [Authorize(Roles = "3")]
        [HttpGet("ListarCandidatosAprovados/{idVaga}")]
        public IActionResult ListarCandidatoAprovados(int idVaga)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                return Ok(_empresaIRepository.ListarCandidatosAprovados(idVaga));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "3")]
        [HttpDelete("DeletarTecnologiaDaVaga")]
        public IActionResult DeletarVagaTecnologia(VagaTecnologia vaga)
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                Empresa empresa = _empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario);
                if (empresa == null)
                    return BadRequest();

                if (_empresaIRepository.RemoverTecnologiaDaVaga(vaga))
                    return Ok("Tecnologia removida da vaga com sucesso");
                else
                    return BadRequest("Não foi possivel remover a tecnologia");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


        [Authorize(Roles = "3")]
        [HttpGet("BuscarEmpresaPorId")]
        public IActionResult BuscarCandidatoPorId()
        {
            try
            {
                var idUsuario = Convert.ToInt32(HttpContext.User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                return Ok(_empresaIRepository.BuscarEmpresaPorIdUsuario(idUsuario));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }
    }
}