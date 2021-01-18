using Hackathon.WebApi.Domains;
using Hackathon.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.WebApi.Interfaces
{
    interface IEmpresaRepository
    {
        bool AtualizarEmpresaPorIdCorpo(int idUsuario, Empresa EmpresaAtualizada);
        bool AtualizarVaga(int idVaga, Vaga vaga);
        bool AdicionarVaga(Vaga vaga);
        bool AdicionarTecnologiaNaVaga(VagaTecnologia vagaTecnologia);
        bool DeletarVaga(int idVaga);
        bool RemoverTecnologiaDaVaga(VagaTecnologia vaga);
        bool AprovarCandidato(int idInscricao);
        bool ReprovarCandidato(int idInscricao);
        List<ListarVagasViewModel> ListarVagasDaEmpresa(int idEmpresa);
        List<Inscricao> ListarCandidatosInscritos(int idVaga);
        List<Inscricao> ListarCandidatosAprovados(int idVaga);
        Empresa BuscarEmpresaPorIdUsuario(int idUsuario);
    }
}
