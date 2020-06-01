using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Apresentação.Models
{
    public class PostViewModel
    { 
        public string Texto { get; set; }

        public string Imagem { get; set; }

        public List<string> Replies { get; set; }


    }
}

