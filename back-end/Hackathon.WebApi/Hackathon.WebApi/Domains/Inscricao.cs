using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hackathon.WebApi.Domains
{
    public partial class Inscricao
    {
        public int IdInscricao { get; set; }
        public DateTime DataInscricao { get; set; }
        public int? IdCandidato { get; set; }
        public int? IdVaga { get; set; }
        public int? IdStatusInscricao { get; set; }

        public virtual Candidato IdCandidatoNavigation { get; set; }
        public virtual StatusInscricao IdStatusInscricaoNavigation { get; set; }
        public virtual Vaga IdVagaNavigation { get; set; }
    }
}
