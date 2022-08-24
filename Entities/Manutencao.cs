﻿using System;
using CiaAerea.Entities.Enums;

namespace CiaAerea.Entities
{
    public class Manutencao
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string? Observacoes { get; set; }
        public TipoManutencao Tipo { get; set; }
        public int AeronaveId { get; set; }
        public Aeronave Aeronave { get; set; } = null!;

        public Manutencao(DateTime dataHora, TipoManutencao tipo, Aeronave aeronave, string observacoes)
        {
            DataHora = dataHora;
            Observacoes = observacoes;
            Tipo = tipo;
            Aeronave = aeronave;
        }
    }
}

