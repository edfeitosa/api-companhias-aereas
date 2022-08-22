﻿using System;
namespace CiaAerea.Entities
{
    public class Piloto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

        public Piloto(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
}

