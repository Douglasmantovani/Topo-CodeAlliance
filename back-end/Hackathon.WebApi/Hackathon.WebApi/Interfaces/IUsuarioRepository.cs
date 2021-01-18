using Hackathon.WebApi.Domains;
using Hackathon.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);
        bool CadastrarCandidato(CadastrarCandidatoViewModel NovoCandidato);
        bool CadastrarEmpresa(CadastrarEmpresaViewModel empresa);
        VagaCompletaViewModel BuscarVagaPeloId(int id);
    }
}
