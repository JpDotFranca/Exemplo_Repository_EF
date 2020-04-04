using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo
{
    public sealed class Cachorro
    {
        [Key]
        public int Identificador { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cor { get; set; }
        public EnumPorteAnimal Porte { get; set; }
    }
}
