using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Aplicação.Controllers
{
    public class Perfil
    {
        public int Id { get; set; }

        public string Usuario { get; set; }
        public DateTime? DataDeNascimento { get; set; }

        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
