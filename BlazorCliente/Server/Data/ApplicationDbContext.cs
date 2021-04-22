using BlazorCliente.Server.Models;
using IdentityServer4.EntityFramework.Options;
using MetaGames.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCliente.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Noticias> Noticias { get; set; }
        public DbSet<Guias> Guias { get; set; }
        public DbSet<CategoriaUsuario> CatUsuarios { get; set; }
    }

    
}
