using Hackathon.WebApi.Contexts;
using Hackathon.WebApi.Domains;
using Hackathon.WebApi.Interfaces;
using Hackathon.WebApi.Utils;
using Hackathon.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.WebApi.Repositories
{
    public class UsuarioRepository:IUsuarioRepository
    {
        public Usuario Login(string email, string senha)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    senha = Crypter.Criptografador(senha);
                    return ctx.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool CadastrarEmpresa(CadastrarEmpresaViewModel empresa)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Usuario usuario = new Usuario()
                    {
                        IdTipoUsuario = 3,
                        Email = empresa.Email.Trim(),
                        Senha = empresa.Senha
                    };

                    Empresa NovaEmpresa = new Empresa()
                    {
                        NomeReponsavel = empresa.NomeReponsavel,
                        Cnpj = empresa.Cnpj.Trim(),
                        EmailContato = empresa.EmailContato.Trim(),
                        NomeFantasia = empresa.NomeFantasia,
                        RazaoSocial = empresa.RazaoSocial,
                        Telefone = empresa.Telefone.Trim(),
                        NumFuncionario = empresa.NumFuncionario,
                        NumCnae = empresa.NumCnae.Trim(),
                        Cep = empresa.Cep.Trim(),
                        Logradouro = empresa.Logradouro,
                        Complemento = empresa.Complemento,
                        Localidade = empresa.Localidade,
                        Uf = empresa.Estado,
                        IdUsuarioNavigation = usuario
                    };
                    ctx.Add(NovaEmpresa);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool CadastrarCandidato(CadastrarCandidatoViewModel NovoCandidato)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Usuario user = new Usuario()
                    {
                        Email = NovoCandidato.Email.Trim(),
                        Senha = NovoCandidato.Senha,
                        IdTipoUsuario = 2
                    };
                    Candidato applicant = new Candidato()
                    {
                        IdUsuarioNavigation = user,
                        NomeCompleto = NovoCandidato.NomeCompleto,
                        Rg = NovoCandidato.Rg.Trim(),
                        Cpf = NovoCandidato.Cpf.Trim(),
                        Telefone = NovoCandidato.Telefone.Trim(),
                        LinkLinkedinCandidato = NovoCandidato.LinkLinkedinCandidato.Trim(),
                    };

                    ctx.Add(applicant);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public VagaCompletaViewModel BuscarVagaPeloId(int idVaga)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    var Vaga = ctx.Vaga.Select(u =>
                    new Vaga
                    {
                        IdVaga = u.IdVaga,
                        IdArea = u.IdArea,
                        TituloVaga = u.TituloVaga,
                        Experiencia = u.Experiencia,
                        TipoContrato = u.TipoContrato,
                        Salario = u.Salario,
                        Localidade = u.Localidade,
                        DescricaoVaga = u.DescricaoVaga,
                        DescricaoBeneficio = u.DescricaoBeneficio,
                        DescricaoEmpresa = u.DescricaoEmpresa,
                        Cep = u.Cep,
                        Estado = u.Estado,
                        Complemento = u.Complemento,
                        Logradouro = u.Logradouro,
                        IdAreaNavigation =
                    new Area { NomeArea = u.IdAreaNavigation.NomeArea },
                        IdTipoRegimePresencialNavigation =
                    new TipoRegimePresencial { NomeTipoRegimePresencial = u.IdTipoRegimePresencialNavigation.NomeTipoRegimePresencial },
                        IdEmpresaNavigation =
                    new Empresa
                    {
                        RazaoSocial = u.IdEmpresaNavigation.RazaoSocial
                    }
                    }).FirstOrDefault(u => u.IdVaga == idVaga);

                    var tecs = ctx.VagaTecnologia.Select(u =>
                    new VagaTecnologia
                    {
                        IdVaga = u.IdVaga,
                        IdTecnologiaNavigation =
                    new Tecnologia { NomeTecnologia = u.IdTecnologiaNavigation.NomeTecnologia }
                    }).Where(u => u.IdVaga == idVaga).ToList();

                    List<string> tecnologias = new List<string>();
                    for (int i = 0; i < tecs.Count; i++)
                    {
                        tecnologias.Add(tecs[i].IdTecnologiaNavigation.NomeTecnologia);
                    }
                    return new VagaCompletaViewModel()
                    {
                        IdVaga = Vaga.IdVaga,
                        IdArea = Vaga.IdArea,
                        TipoContrato = Vaga.TipoContrato,
                        TituloVaga = Vaga.TituloVaga,
                        TipoPresenca = Vaga.IdTipoRegimePresencialNavigation.NomeTipoRegimePresencial,
                        Salario = Vaga.Salario,
                        DescricaoBeneficio = Vaga.DescricaoBeneficio,
                        DescricaoEmpresa = Vaga.DescricaoEmpresa,
                        DescricaoVaga = Vaga.DescricaoVaga,
                        Experiencia = Vaga.Experiencia,
                        NomeArea = Vaga.IdAreaNavigation.NomeArea,
                        RazaoSocial = Vaga.IdEmpresaNavigation.RazaoSocial,
                        Localidade = Vaga.Localidade,
                        Complemento = Vaga.Complemento,
                        Cep = Vaga.Cep,
                        Estado = Vaga.Estado,
                        Logradouro = Vaga.Logradouro,
                        Tecnologias = tecnologias,
                    };
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}
