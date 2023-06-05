using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Book
    {
        
        public int bookId { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public enum status { borrowed, free, reserved };
        public virtual IEnumerable<Borrow> borrows { get; set; }
    }
    public class BookDatabase : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<Borrow> borrows { get; set; }
    }
}