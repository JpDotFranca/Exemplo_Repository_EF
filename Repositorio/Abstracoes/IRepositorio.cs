using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Repositorio.Abstracoes
{
    public interface IRepositorio<TipoEntidade> where TipoEntidade: class
    {
        TipoEntidade Buscar(int identificador);
        List<TipoEntidade> BuscarTodos();
        List<TipoEntidade> Encontrar(Expression<Func<TipoEntidade, bool>> expressao);

        void Adicionar(TipoEntidade entidade);
        void Adicionar(List<TipoEntidade> entidades);
        void Remover(TipoEntidade entidade);
        void Remover(List<TipoEntidade> entidades);
    }
}
