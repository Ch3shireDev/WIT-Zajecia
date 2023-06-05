using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Wypozyczenia
    {
        [Key]
        public int wypozyczeniaId { get; set; }
        public DateTime dataWyp { get; set; }
        public DateTime dataZwr { get; set; }
        
        public uint czytelnikId { get; set; }
        
        public uint ksiazkaId { get; set; }
        public virtual Czytelnik czytel { get; set; }
        public virtual Ksiazka ksiazka { get; set; }
    }
    public class bazaWyp : DbContext
    {
        public DbSet<Wypozyczenia> baza { get; set; }
      
    }
}