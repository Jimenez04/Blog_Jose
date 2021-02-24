using Blog_Jose.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog_Jose.AccesoBD.Data.Repositorio
{
    public interface ICategoriaRepositorio: IRepositorio<Categoria>
    {
        IEnumerable<SelectListItem> GetListaCategoria();

        void Update(Categoria categoria);

    }
}
