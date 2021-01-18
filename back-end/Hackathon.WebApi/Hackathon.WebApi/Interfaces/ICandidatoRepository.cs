using Hackathon.WebApi.Domains;
using Hackathon.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.WebApi.Interfaces
{
    interface ICandidatoRepository
    {
        bool AtualizarCandidato(int IdCandidato, Candidato CandidatoAtualizado);
        List<ListarVagasViewModel> ListarInscricoes(int idUsuario);
        bool SeInscrever(Inscricao NovaInscricao);
        bool RevogarInscricao(int idInscricao, int idCandidato);
        List<ListarVagasViewModel> ListarVagasArea(int idCurso);
        /*------------VERIFICAÇÕES INICIO-------------*/
        Candidato BuscarCandidatoPorIdUsuario(int idUsuario);
    }
}
