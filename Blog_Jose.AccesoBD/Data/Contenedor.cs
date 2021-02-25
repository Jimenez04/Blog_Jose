using Blog_Jose.AccesoBD.Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog_Jose.AccesoBD.Data
{
    public class Contenedor : IContenedor
    {

        private readonly ApplicationDbContext context;

        public Contenedor(ApplicationDbContext context)
        {
            this.context = context;
            categoria = new CategoriaRepositorio(context);

        }

        public ICategoriaRepositorio categoria { get; private set; }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
