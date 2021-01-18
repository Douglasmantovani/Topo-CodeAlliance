using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hackathon.WebApi.Domains
{
    public partial class Tecnologia
    {
        public Tecnologia()
        {
            VagaTecnologia = new HashSet<VagaTecnologia>();
        }

        public int IdTecnologia { get; set; }
        public string NomeTecnologia { get; set; }

        public virtual ICollection<VagaTecnologia> VagaTecnologia { get; set; }
    }
}
