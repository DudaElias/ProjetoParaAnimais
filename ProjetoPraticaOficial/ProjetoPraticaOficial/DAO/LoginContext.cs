using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.Models;

namespace ProjetoPraticaOficial.DAO
{
    public class LoginContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=regulus.cotuca.unicamp.br;Initial Catalog='PR118343'; User ID ='PR118343'; Password ='PR118343'");
        }
    }
}