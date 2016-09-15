using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Fecap.Aula01.Web.Models;

namespace Fecap.Aula01.Web.BancoDados
{
    //Classe que manipula o banco de dados
    public class Banco : DbContext
    {
        public DbSet<Pastel> Pasteis { get; set; }
    }
}