using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hackathon.WebApi.Domains
{
    public partial class Empresa
    {
        public Empresa()
        {
            Vaga = new HashSet<Vaga>();
        }

        public int IdEmpresa { get; set; }
        public string NomeReponsavel { get; set; }
        public string Cnpj { get; set; }
        public string EmailContato { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string Telefone { get; set; }
        public int NumFuncionario { get; set; }
        public string NumCnae { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public int IdUsuario { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Vaga> Vaga { get; set; }
    }
}
