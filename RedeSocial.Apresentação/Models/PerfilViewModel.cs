using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Apresentação.Models
{
    public class PerfilViewModel
    { 
        public string NomeDeUsuario { get; set; }

        public string Email { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Senha { get; set; }
    }

}
