using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class SearchBook
    {
        public string searchByTitle { get; set; }
        public string searchByAuthor { get; set; }
        public string searchByStatus { get; set; }
    }
    public class SearchReader
    {
        public string searchBySurname { get; set; }
        public string searchById { get; set; }
    }
    public class SearchBorrow
    {
        public string searchByDateBorrow { get; set; }
        public string searchByDateReturn { get; set; }
        public string searchByReader { get; set; }
    }
}