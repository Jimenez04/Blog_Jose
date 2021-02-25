using System;
using System.Collections.Generic;
using System.Text;

namespace Blog_Jose.AccesoBD.Data.Repositorio
{
   public interface IContenedor : IDisposable
    {
        ICategoriaRepositorio categoria { get; }


        void Save();
    }
}
