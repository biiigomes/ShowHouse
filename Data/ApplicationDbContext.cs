using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvc_desafio_master.DTO;
using mvc_desafio_master.Models;
using MVChallenge.Models;

namespace MVChallenge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<CasaShow> CasaShows {get; set;}
        public DbSet<Evento> Eventos {get; set;}
        public DbSet<Estilo> Estilos {get; set;}
        public DbSet<Login> Logins {get; set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
