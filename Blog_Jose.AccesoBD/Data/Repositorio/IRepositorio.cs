using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blog_Jose.AccesoBD.Data.Repositorio
{
     public interface IRepositorio<T> where T : class
    {
        T GetT(int id);

        IEnumerable<T> GetAll
            (
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string includeProperties = null
            );

        T GetFirstOrDefault
            (
              Expression<Func<T, bool>> filter = null,
               string includeProperties = null
            );

        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);

        //El metodo update puede cambiar para cada repositorio.

        ///Por otro lado, estos son los mas comunes.
    }
}
