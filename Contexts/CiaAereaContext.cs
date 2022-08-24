using System;
using CiaAerea.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiaAerea.Contexts
{
    public class CiaAereaContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
        public DbSet<Cancelamento> Cancelamentos => Set<Cancelamento>();
        public DbSet<Manutencao> Manutencoes => Set<Manutencao>();
        public DbSet<Piloto> Pilotos => Set<Piloto>();
        public DbSet<Voo> Voos => Set<Voo>();

        public CiaAereaContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("CiaAerea"));
        }
    }
}

