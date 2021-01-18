using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackathon.WebApi.Domains;
using Hackathon.WebApi.Interfaces;
using Hackathon.WebApi.Repositories;
using Hackathon.WebApi.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {
        IAdministradorRepository _Admin { get; set; }

        public AdministradorController()
        {
            _Admin = new AdministradorRepository();
        }

        [Authorize(Roles = "1")]
        [HttpGet("BuscarCandidatoPorIdAdm/{id}")]
        public IActionResult BuscarCandidatoPorId(int id)
        {
            try
            {
                return Ok(_Admin.BuscarCandidatoPorIdUsuarioAdm(id));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("ListarVagasEmpresaAdm/{id}")]
        public IActionResult ListarVagas(int id)
        {
            try
            {
                Empresa empresa = _Admin.BuscarEmpresaPorIdUsuarioAdm(id);
                if (empresa == null)
                    return BadRequest();

                return Ok(_Admin.ListarVagasDaEmpresaAdm(empresa.IdEmpresa));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("BuscarEmpresaPorIdAdm/{id}")]
        public IActionResult BuscarEmpresaPorId(int id)
        {
            try
            {
                return Ok(_Admin.BuscarEmpresaPorIdUsuarioAdm(id));
            }
            catch (Exception)
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }


        [Authorize(Roles = "1")]
        [HttpGet("ListarCandidatosInscritosAdm/{idVaga}")]
        public IActionResult ListarCandidatosInscritos(int idVaga)
        {
            try
            {
                return Ok(_Admin.ListarCandidatosInscritosEmpresa(idVaga));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("ListarBanidos")]
        public IActionResult ListaBanidos()
        {
            try
            {
                return Ok(_Admin.ListarBanidos());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpGet("ListarColaboradores")]
        public IActionResult ListaAdministradores()
        {
            try
            {
                return Ok(_Admin.ListarAdministradores());
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("DeletarUsuarioBanido/{id}")]
        public IActionResult DeletarUsuarioBanido(int id)
        {
            try
            {
                if (_Admin.DeletarUsuarioBanido(id))
                    return Ok("Usuario deletado com sucesso");
                else
                    return BadRequest("Não foi possivel deletar o usuario");
            }
            catch
            {
                return BadRequest("Uma exceção ocorreu. Tente novamente.");
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("DeletarInscricao/{idInscricao}")]
        public IActionResult DeletarInscricao(int idInscricao)
        {
            try
            {
                if (_Admin.DeletarInscricao(idInscricao))
                    return Ok("Inscricao deletada com sucesso");
                else
                    return BadRequest("Não foi possivel deletar a Inscricao");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("DeletarAdminstrador/{idUsuario}")]
        public IActionResult DeletarAdministrador(int idUsuario)
        {
            try
            {
                if (_Admin.DeletarAdministrador(idUsuario))
                    return Ok("Administrador deletado com sucesso");
                else
                    return BadRequest("Não foi possivel deletar o adminstrador");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("DeletarVaga/{idVaga}")]
        public IActionResult DeletarVaga(int idVaga)
        {
            try
            {
                if (_Admin.DeletarVagaEmpresa(idVaga))
                    return Ok("Vaga deletada com sucesso");
                else
                    return BadRequest("Não foi possivel deletar a Vaga");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost("AdicionarArea")]
        public IActionResult CadastrarArea(Area NovaArea)
        {
            try
            {
                if (_Admin.CadastrarArea(NovaArea))
                    return StatusCode(201);
                else
                    return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost("AdicionarColaborador")]
        public IActionResult CadastrarAdministrador(Usuario usuarioAdmin)
        {
            try
            {
                usuarioAdmin.Senha = Crypter.Criptografador(usuarioAdmin.Senha);
                if (_Admin.CadastrarAdministardor(usuarioAdmin))
                    return StatusCode(201);
                else
                    return BadRequest();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost("AdicionarTecnologia")]
        public IActionResult CadastrarTecnologia(Tecnologia novaTecnologia)
        {
            try
            {
                if (_Admin.CadastrarTecnologia(novaTecnologia))
                    return StatusCode(201);

                else
                    return BadRequest("Não foi possivel adicionar essa tecnologia");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        
        [Authorize(Roles = "1")]
        [HttpPut("AlterarSenhaDeQualquerUsuario")]
        public IActionResult AterarSenhaDeQualquerUsuario(Usuario usuario)
        {
            try
            {
                if (_Admin.AlterarSenhaDoUsuario(usuario.Email, usuario.Senha))
                    return Ok("Senha alterada com sucesso");
                else
                    return BadRequest("Não foi possivel alterar a senha para o email informado");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("AtualizarArea/{id}")]
        public IActionResult AtualizarArea(int idArea, Area area)
        {
            try
            {
                if (_Admin.AtualizarArea(idArea, area))
                    return Ok("Area atualizado com sucesso");
                else
                    return BadRequest("Não foi possivel atualizar a area");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("Banir/{id}")]
        public IActionResult BanirUsuario(int id)
        {
            try
            {
                if (_Admin.BanirUsuario(id))
                    return Ok("Usuário banido");
                else
                    return NotFound("Erro ao banir esse usuário ");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("Desbanir/{id}")]
        public IActionResult DesbanirUsuario(int id)
        {
            try
            {
                if (_Admin.DesbanirUsuario(id))
                    return Ok("Usuário desbanido");
                else
                    return NotFound("Erro ao banir esse usuário ");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}