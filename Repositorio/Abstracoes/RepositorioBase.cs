using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Repositorio.Abstracoes
{
    public class RepositorioBase<TipoEntidade> : IRepositorio<TipoEntidade> where TipoEntidade : class
    {
        protected readonly DbContext Contexto;

        public RepositorioBase(DbContext contexto)
        {
            Contexto = contexto;
        }
        public void Adicionar(TipoEntidade entidade)
        {
            Contexto.Set<TipoEntidade>().Add(entidade);
        }
        public void Adicionar(List<TipoEntidade> entidades)
        {
            throw new NotImplementedException();
        }
        public TipoEntidade Buscar(int identificador)
        {
            return Contexto.Set<TipoEntidade>().Find(identificador);
        }
        public List<TipoEntidade> BuscarTodos()
        {
            return Contexto.Set<TipoEntidade>().ToList();
        }
        public List<TipoEntidade> Encontrar(Expression<Func<TipoEntidade, bool>> expressao)
        {
            return Contexto.Set<TipoEntidade>().Where(expressao).ToList();
        }
        public void Remover(TipoEntidade entidade)
        {
            Contexto.Set<TipoEntidade>().Remove(entidade);
        }
        public void Remover(List<TipoEntidade> entidades)
        {
            Contexto.Set<TipoEntidade>().RemoveRange(entidades);
        }
    }
}
