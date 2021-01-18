using Hackathon.WebApi.Domains;
using Hackathon.WebApi.Domains;
using Hackathon.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.WebApi.Interfaces
{
    interface IAdministradorRepository
    {
        bool CadastrarArea(Area area);
        Candidato BuscarCandidatoPorIdUsuarioAdm(int idUsuario);
        List<ListarVagasViewModel> ListarVagasDaEmpresaAdm(int idEmpresa);
        bool AtualizarArea(int idArea, Area area);
        Empresa BuscarEmpresaPorIdUsuarioAdm(int idUsuario);
        bool DeletarUsuarioBanido(int idUsuario);
        bool CadastrarTecnologia(Tecnologia tecnologia);
        bool DeletarCandidato(int IdUsuario);
        bool DeletarInscricao(int idInscricao);
        bool DeletarEmpresaPorId(int idUsuario);
        bool DeletarVagaEmpresa(int idVaga);
        bool BanirUsuario(int id);
        bool DesbanirUsuario(int id);
        List<Usuario> ListarBanidos();
        bool CadastrarAdministardor(Usuario usuario);
        bool DeletarAdministrador(int id);
        List<Usuario> ListarAdministradores();
        bool AlterarSenhaDoUsuario(string email, string NovaSenha);
        List<Inscricao> ListarCandidatosInscritosEmpresa(int idVaga);
    }
}
