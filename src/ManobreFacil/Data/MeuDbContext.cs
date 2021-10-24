using ManobreFacil.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManobreFacil.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Manobra> Manobras { get; set; }
        public DbSet<Manobrista> Manobristas { get; set; }
    }
}
