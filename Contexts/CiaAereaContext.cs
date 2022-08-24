using System;
using CiaAerea.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiaAerea.Contexts
{
    public class CiaAereaContext: DbContext
    {
        public DbSet<Aeronave> Aeronaves => Set<Aeronave>();
        public DbSet<Cancelamento> Cancelamentos => Set<Cancelamento>();
        public DbSet<Manutencao> Manutencoes => Set<Manutencao>();
        public DbSet<Piloto> Pilotos => Set<Piloto>();
        public DbSet<Voo> Voos => Set<Voo>();

        public CiaAereaContext()
        {
        }
    }
}

