using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Ksiazka
    {
        public int ksiazkaId{ get; private set; }
        public string tytul { get; private set; }
        public string autor { get; private set; }
        public enum status { wyp,wolna}
        public virtual IEnumerable<Wypozyczenia> wyp { get; set; }
    }
    public class bazaKsiazka : DbContext
    {
        public DbSet<Ksiazka> baza { get; set;}
        public DbSet<Wypozyczenia> wypBaza { get; set; }
    }
}