using Modelo;
using Repositorio.Abstracoes;
using System.Collections.Generic;

namespace Repositorio.RepCachorro
{
    public interface IRepositorioCachorro : IRepositorio<Cachorro>
    {
        List<Cachorro> BuscarPorPorte(EnumPorteAnimal porte);
    }
}
