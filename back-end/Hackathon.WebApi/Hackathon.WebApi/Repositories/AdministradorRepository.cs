using Hackathon.WebApi.Contexts;
using Hackathon.WebApi.Domains;
using Hackathon.WebApi.Interfaces;
using Hackathon.WebApi.Utils;
using Hackathon.WebApi.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.WebApi.Repositories
{
    public class AdministradorRepository : EmpresaRepository, IAdministradorRepository
    {
       
        public bool CadastrarTecnologia(Tecnologia tecnologia)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    ctx.Add(tecnologia);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeletarInscricao(int idInscricao)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Inscricao inscricaoBuscada = ctx.Inscricao.Find(idInscricao);
                    if (inscricaoBuscada == null)
                        return false;

                    ctx.Remove(inscricaoBuscada);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool DeletarEmpresaPorId(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Empresa empresaBuscado = ctx.Empresa.FirstOrDefault(u => u.IdUsuario == idUsuario);
                    if (empresaBuscado == null)
                        return false;

                    List<VagaTecnologia> ListaDeVagaTecnologia = ctx.VagaTecnologia.Where(i => i.IdVagaNavigation.IdEmpresa == empresaBuscado.IdEmpresa).ToList();
                    for (int i = 0; i < ListaDeVagaTecnologia.Count; i++)
                    {
                        VagaTecnologia vaga = new VagaTecnologia()
                        {
                            IdTecnologia = ListaDeVagaTecnologia[i].IdTecnologia,
                            IdVaga = ListaDeVagaTecnologia[i].IdVaga
                        };
                        if (RemoverTecnologiaDaVaga(vaga))
                            continue;

                        break;
                    }

                    List<Vaga> ListaDeVaga = ctx.Vaga.Where(i => i.IdEmpresa == empresaBuscado.IdEmpresa).ToList();
                    for (int i = 0; i < ListaDeVaga.Count; i++)
                    {
                        if (DeletarVaga(ListaDeVaga[i].IdVaga))
                            continue;
                    }
                    DeletarUsuarioEmpresaCandidato(empresaBuscado.IdUsuario);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        public bool DeletarCandidato(int IdUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Candidato CandidatoBuscado = ctx.Candidato.FirstOrDefault(u => u.IdUsuario == IdUsuario);
                    if (CandidatoBuscado == null)
                        return false;

                    List<Inscricao> listaDeInscricao = ctx.Inscricao.
                        Where(l => l.IdCandidato == CandidatoBuscado.IdCandidato).ToList();
                    for (int i = 0; i < listaDeInscricao.Count; i++)
                    {
                        DeletarInscricao(listaDeInscricao[i].IdInscricao);
                    }
                    DeletarUsuarioEmpresaCandidato(CandidatoBuscado.IdUsuario);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }


        /// <summary>
        /// Foi necessario criar esse metodo para poder deletar empresa/Candidato e usuario,no mesmo metodo estava dando erro
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public bool DeletarUsuarioEmpresaCandidato(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Usuario usuarioBuscado = ctx.Usuario.Find(idUsuario);
                    Empresa empresaBuscada = ctx.Empresa.FirstOrDefault(e => e.IdUsuario == idUsuario);
                    if (empresaBuscada != null)
                    {
                        ctx.Remove(empresaBuscada);
                        ctx.Remove(usuarioBuscado);
                        ctx.SaveChanges();
                        return true;
                    }

                    Candidato candidatoBuscado = ctx.Candidato.FirstOrDefault(e => e.IdUsuario == idUsuario);
                    if (candidatoBuscado != null)
                    {
                        ctx.Remove(candidatoBuscado);
                        ctx.Remove(usuarioBuscado);
                        ctx.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        
        public bool DeletarVagaEmpresa(int idVaga)
        {
            try
            {
                return DeletarVaga(idVaga);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Usuario> ListarBanidos()
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    return ctx.Usuario.Where(u => u.IdTipoUsuario == 4).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public bool DesbanirUsuario(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Empresa empresaBuscada = ctx.Empresa.Include(u => u.IdUsuarioNavigation).FirstOrDefault(e => e.IdUsuario == idUsuario);
                    if (empresaBuscada != null)
                    {
                        if (empresaBuscada.IdUsuarioNavigation.IdTipoUsuario != 3)
                        {
                            empresaBuscada.IdUsuarioNavigation.IdTipoUsuario = 3;
                            ctx.Update(empresaBuscada);
                            ctx.SaveChanges();
                            return true;
                        }
                        return false;
                    }
                    Candidato candidatoBuscado = ctx.Candidato.Include(u => u.IdUsuarioNavigation).FirstOrDefault(e => e.IdUsuario == idUsuario);
                    if (candidatoBuscado != null)
                    {
                        if (candidatoBuscado.IdUsuarioNavigation.IdTipoUsuario != 2)
                        {
                            candidatoBuscado.IdUsuarioNavigation.IdTipoUsuario = 2;
                            ctx.Update(candidatoBuscado);
                            ctx.SaveChanges();
                            return true;
                        }
                    }
                    Usuario ColaboradorBuscado = ctx.Usuario.Find(idUsuario);
                    if (empresaBuscada == null && candidatoBuscado == null && ColaboradorBuscado != null && ColaboradorBuscado.IdTipoUsuario == 4)
                    {
                        ColaboradorBuscado.IdTipoUsuario = 1;
                        ctx.Update(ColaboradorBuscado);
                        ctx.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public bool BanirUsuario(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Usuario usuarioBuscadoCandidato = ctx.Usuario.Include(u => u.Candidato).FirstOrDefault(u => u.IdUsuario == idUsuario);
                    Usuario usuarioBuscadoEmpresa = ctx.Usuario.Include(u => u.Empresa).FirstOrDefault(u => u.IdUsuario == idUsuario);
                    Usuario usuarioBuscadoColaborador = ctx.Usuario.Find(idUsuario);
                    if (usuarioBuscadoCandidato == null && usuarioBuscadoEmpresa == null && usuarioBuscadoColaborador == null)
                        return false;

                    if (usuarioBuscadoCandidato.IdTipoUsuario != 4 && usuarioBuscadoCandidato.Candidato != null)
                    {
                        Candidato candidato = ctx.Candidato.Include(u => u.Inscricao).FirstOrDefault(u => u.IdUsuarioNavigation.IdUsuario == usuarioBuscadoCandidato.IdUsuario);
                        for (int i = 0; i < candidato.Inscricao.Count; i++)
                        {
                            Inscricao inscricao = ctx.Inscricao.FirstOrDefault(u => u.IdCandidato == candidato.IdCandidato);
                            if (inscricao == null)
                                break;
                            DeletarInscricao(inscricao.IdInscricao);
                        }
                        usuarioBuscadoCandidato.IdTipoUsuario = 4;
                        ctx.Update(usuarioBuscadoCandidato);
                        ctx.SaveChanges();
                        return true;
                    }
                    else if (usuarioBuscadoEmpresa.IdTipoUsuario != 4 && usuarioBuscadoEmpresa.Empresa != null)
                    {
                        Empresa empresaBuscada = ctx.Empresa.Include(u => u.Vaga).FirstOrDefault(u => u.IdUsuarioNavigation.IdUsuario == usuarioBuscadoEmpresa.IdUsuario);
                        for (int i = 0; i < empresaBuscada.Vaga.Count; i++)
                        {
                            Vaga vagaBuscada = ctx.Vaga.FirstOrDefault(u => u.IdEmpresa == empresaBuscada.IdEmpresa);
                            if (vagaBuscada == null)
                                break;

                            DeletarVaga(vagaBuscada.IdVaga);
                        }
                        usuarioBuscadoEmpresa.IdTipoUsuario = 4;
                        ctx.Update(usuarioBuscadoEmpresa);
                        ctx.SaveChanges();
                        return true;
                    }
                    else if (usuarioBuscadoColaborador.IdTipoUsuario != 4 && usuarioBuscadoColaborador.IdTipoUsuario == 1)
                    {
                        usuarioBuscadoColaborador.IdTipoUsuario = 4;
                        ctx.Update(usuarioBuscadoColaborador);
                        ctx.SaveChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool CadastrarAdministardor(Usuario usuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    usuario.IdTipoUsuario = 1;
                    ctx.Add(usuario);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool DeletarAdministrador(int id)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Usuario usuario = ctx.Usuario.Find(id);
                    if (usuario.IdTipoUsuario != 1 || usuario == null || usuario.IdUsuario == 1)
                        return false;
                    else
                    {
                        ctx.Remove(usuario);
                        ctx.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<Usuario> ListarAdministradores()
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    return ctx.Usuario.Where(v => v.IdTipoUsuario == 1).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool CadastrarArea(Area area)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    ctx.Add(area);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AtualizarArea(int idArea, Area area)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Area areaBuscada = ctx.Area.Find(idArea);
                    if (area.NomeArea != null)
                        areaBuscada.NomeArea = area.NomeArea;

                    ctx.Update(areaBuscada);
                    ctx.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AlterarSenhaDoUsuario(string email, string NovaSenha)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    var usuario = ctx.Usuario.FirstOrDefault(u => u.Email == email);
                    if (usuario == null)
                        return false;
                    else
                    {
                        usuario.Senha = Crypter.Criptografador(NovaSenha);
                        ctx.Update(usuario);
                        ctx.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public List<Inscricao> ListarCandidatosInscritosEmpresa(int idVaga)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    return ctx.Inscricao.Select(u =>
                        new Inscricao
                        {
                            IdVaga = u.IdVaga,
                            IdInscricao = u.IdInscricao,
                            IdCandidato = u.IdCandidato,
                            IdCandidatoNavigation =
                        new Candidato
                        {
                            NomeCompleto = u.IdCandidatoNavigation.NomeCompleto,
                            Telefone = u.IdCandidatoNavigation.Telefone,
                            IdUsuarioNavigation =
                        new Usuario { Email = u.IdCandidatoNavigation.IdUsuarioNavigation.Email }
                        }
                        })
                        .Where(u => u.IdVaga == idVaga).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }


        public Empresa BuscarEmpresaPorIdUsuarioAdm(int idUsuario)
        {
            try
            {
                return BuscarEmpresaPorIdUsuario(idUsuario);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ListarVagasViewModel> ListarVagasDaEmpresaAdm(int idEmpresa)
        {
            try
            {
                return ListarVagasDaEmpresa(idEmpresa);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public Candidato BuscarCandidatoPorIdUsuarioAdm(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    return ctx.Candidato.Select(u =>
                    new Candidato
                    {
                        IdUsuario = u.IdUsuario,
                        IdCandidato = u.IdCandidato,
                        NomeCompleto = u.NomeCompleto,
                        Rg = u.Rg,
                        Cpf = u.Cpf,
                        LinkLinkedinCandidato = u.LinkLinkedinCandidato,
                        Telefone = u.Telefone
                    })
                    .FirstOrDefault(u => u.IdUsuario == idUsuario);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public List<ListarVagasViewModel> ListarInscricoes(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Candidato candidato = ctx.Candidato.FirstOrDefault(c => c.IdUsuario == idUsuario);
                    if (candidato == null)
                        return null;

                    List<Inscricao> ListaDeInscricoes = ctx.Inscricao.Where(v => v.IdCandidato == candidato.IdCandidato).ToList();
                    if (ListaDeInscricoes == null)
                        return null;

                    List<ListarVagasViewModel> ListVaga = new List<ListarVagasViewModel>();
                    for (int i = 0; i < ListaDeInscricoes.Count; i++)
                    {
                        Vaga v = ctx.Vaga.Select(u =>
                        new Vaga
                        {
                            TituloVaga = u.TituloVaga,
                            IdVaga = u.IdVaga,
                            IdAreaNavigation =
                        new Area { NomeArea = u.IdAreaNavigation.NomeArea }
                        })
                        .FirstOrDefault(u => u.IdVaga == ListaDeInscricoes[i].IdVaga);
                        ListVaga.Add(new ListarVagasViewModel()
                        {
                            TituloVaga = v.TituloVaga,
                            IdVaga = v.IdVaga,
                            IdInscricao = ListaDeInscricoes[i].IdInscricao,
                            NomeArea = v.IdAreaNavigation.NomeArea
                        });
                    }
                    return ListVaga;

                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public bool DeletarUsuarioBanido(int idUsuario)
        {
            using (HackathonContext ctx = new HackathonContext())
            {
                try
                {
                    Candidato c = ctx.Candidato.FirstOrDefault(u => u.IdUsuario == idUsuario);
                    if (c == null)
                    {
                        Empresa e = ctx.Empresa.FirstOrDefault(u => u.IdUsuario == idUsuario);
                        if (e == null)
                            return false;

                        DeletarEmpresaPorId(e.IdUsuario);
                        return true;
                    }
                    else
                    {
                        DeletarCandidato(c.IdUsuario);
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}