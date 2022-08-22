using System;
namespace CiaAerea.Entities
{
    public class Aeronave
    {
        public int Id { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Codigo { get; set; }


        public Aeronave(string fabricante, string modelo, string codigo)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Codigo = codigo;
        }
    }
}

