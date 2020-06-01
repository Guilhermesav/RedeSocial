using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedeSocial.Aplicação.Controllers;

namespace RedeSocial.Aplicação.Data
{
    public class RedeSocialAplicaçãoContext : DbContext
    {
        public RedeSocialAplicaçãoContext(DbContextOptions<RedeSocialAplicaçãoContext> options)
            : base(options)
        {
        }

        public DbSet<RedeSocial.Aplicação.Controllers.Perfil> Perfil { get; set; }
    }

    public class PostRepository
    {
        public  PostRepository(RedeSocialAplicaçãoContext context)
        {
            Context = context;
        }

        private RedeSocialAplicaçãoContext Context { get; }

    }
}
