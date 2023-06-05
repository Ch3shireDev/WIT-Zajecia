using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Borrow
    {
        public int borrowId { get; set; }
        public DateTime dateBorrow { get; set; }
        public DateTime dateReturn { get; set; }
        public int readerId { get; set; }
        public int bookId { get; set; }
        public virtual Reader readers { get; set; } //odniesienie do tabeli Reader, jako FK jest IDCard
        public virtual Book books { get; set; }
    }
    public class BorrowDatabase : DbContext
    {
        public DbSet<Borrow> borrows { get; set; }
    }
}