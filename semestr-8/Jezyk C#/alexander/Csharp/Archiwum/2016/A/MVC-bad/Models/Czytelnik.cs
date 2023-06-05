using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC.Models
{
    public class Czytelnik
    {
        public int czytelnikId{ get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public virtual IEnumerable<Wypozyczenia> wyp { get; set; }
    }
    public class bazaCzytelnik : DbContext
    {
       public DbSet<Czytelnik> baza { get; set; }
      
    }
}