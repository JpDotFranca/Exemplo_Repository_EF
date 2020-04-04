using Modelo;
using System;
using System.Data.Entity;

namespace Repositorio.Contextos
{
    public class ContextoBancoDadosCachorro: DbContext
    {
        public DbSet<Cachorro> Cachorros { get; set; }


        static void Main(string[] args)
        {
            var a = new ContextoBancoDadosCachorro();

            Cachorro c = a.Cachorros.Find(2);



            a.Cachorros.Remove(c);
           
            a.SaveChanges();
        }

    }


}
