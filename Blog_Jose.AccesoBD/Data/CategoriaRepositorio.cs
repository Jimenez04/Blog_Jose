using Blog_Jose.AccesoBD.Data.Repositorio;
using Blog_Jose.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog_Jose.AccesoBD.Data
{
    public class CategoriaRepositorio : Repositorios<Categoria>, ICategoriaRepositorio
    {
        private readonly ApplicationDbContext db;

        public CategoriaRepositorio(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public IEnumerable<SelectListItem> GetListaCategoria() //Obtener una lista
        {
            return db.Categoria.Select(x => new SelectListItem()
            {
                Text = x.Nombre,
                Value = x.Id.ToString(),
            });
        }

        public void Update(Categoria categoria)
        {
            var ObjetoBD = db.Categoria.FirstOrDefault(s => s.Id == categoria.Id);
            ObjetoBD.Nombre = categoria.Nombre;
            ObjetoBD.Orden = categoria.Orden;

            db.SaveChanges();
        }
    }
}
