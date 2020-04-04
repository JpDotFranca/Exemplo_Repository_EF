using Modelo;
using Repositorio.Abstracoes;
using Repositorio.Contextos;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.RepCachorro
{
    public class RepositorioCachorro : RepositorioBase<Cachorro>, IRepositorioCachorro
    {
        public RepositorioCachorro(ContextoBancoDadosCachorro contexto) : base(contexto) { }
        public List<Cachorro> BuscarPorPorte(EnumPorteAnimal porte)
        {
            return ContextoCachorro.Cachorros.Where(cachorro => cachorro.Porte == porte).ToList();
        }

        public ContextoBancoDadosCachorro ContextoCachorro
        {
            get { return Contexto as ContextoBancoDadosCachorro; }
        }
    }
}
