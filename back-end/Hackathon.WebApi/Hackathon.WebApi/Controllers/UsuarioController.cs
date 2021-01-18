using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon.WebApi.Interfaces;
using Hackathon.WebApi.Repositories;
using Hackathon.WebApi.Utils;
using Hackathon.WebApi.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.WebApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository usuarioRepository { get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }


        [HttpPost("Candidato")]
        public IActionResult CadastrarCandidato(CadastrarCandidatoViewModel NovoCandidato)
        {
            try
            {

                    NovoCandidato.Senha = Crypter.Criptografador(NovoCandidato.Senha);
                    if (usuarioRepository.CadastrarCandidato(NovoCandidato))
                        return Ok("Novo candidato inserido com sucesso!");
                    else
                        return BadRequest("Um erro ocorreu ao receber a sua requisição.");
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }


        [HttpPost("Empresa")]
        public IActionResult CadastrarEmpresa(CadastrarEmpresaViewModel empresa)
        {
            try
            {
                    empresa.Senha = Crypter.Criptografador(empresa.Senha);
                    if (usuarioRepository.CadastrarEmpresa(empresa))
                        return Ok("Nova empresa cadastrada com sucesso!");
                    else
                        return BadRequest("Um erro ocorreu e nao foi possivel efetuar o cadastro.");
            }
            catch (Exception e)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize]
        [HttpGet("BuscarPorId/{idVaga}")]
        public IActionResult BuscarVagaPeloId(int idVaga)
        {
            try
            {
                return Ok(usuarioRepository.BuscarVagaPeloId(idVaga));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}