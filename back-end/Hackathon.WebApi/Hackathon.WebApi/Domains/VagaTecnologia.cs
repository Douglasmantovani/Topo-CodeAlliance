using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hackathon.WebApi.Domains
{
    public partial class VagaTecnologia
    {
        public int IdTecnologia { get; set; }
        public int IdVaga { get; set; }

        public virtual Tecnologia IdTecnologiaNavigation { get; set; }
        public virtual Vaga IdVagaNavigation { get; set; }
    }
}
