using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hackathon.WebApi.Domains
{
    public partial class TipoRegimePresencial
    {
        public TipoRegimePresencial()
        {
            Vaga = new HashSet<Vaga>();
        }

        public int IdTipoRegimePresencial { get; set; }
        public string NomeTipoRegimePresencial { get; set; }

        public virtual ICollection<Vaga> Vaga { get; set; }
    }
}
