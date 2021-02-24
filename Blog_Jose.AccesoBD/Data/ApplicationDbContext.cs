using System;
using System.Collections.Generic;
using System.Text;
using Blog_Jose.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog_Jose.AccesoBD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Categoria> Categoria { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
