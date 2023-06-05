using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Reader
    {
        
        public int readerId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public virtual ICollection<Borrow> borrows { get; set; }

    }
    public class ReaderDatabase : DbContext
    {
        public DbSet<Reader> readers { get; set; }
        public DbSet<Borrow> borrows { get; set; }
    }
}