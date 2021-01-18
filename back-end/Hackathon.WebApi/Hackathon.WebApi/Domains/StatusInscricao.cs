using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hackathon.WebApi.Domains
{
    public partial class StatusInscricao
    {
        public StatusInscricao()
        {
            Inscricao = new HashSet<Inscricao>();
        }

        public int IdStatusInscricao { get; set; }
        public string NomeStatusInscricao { get; set; }

        public virtual ICollection<Inscricao> Inscricao { get; set; }
    }
}
