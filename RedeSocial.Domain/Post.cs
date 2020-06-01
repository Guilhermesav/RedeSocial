using System;
using System.Collections.Generic;

namespace RedeSocial.Domain
{
    public class Post
    {
        public int Id { get; set; }

        public string Texto { get; set; }

        public string ImagemDePost { get; set; }

        public List<string> Respostas { get; set; } 

    }
}
