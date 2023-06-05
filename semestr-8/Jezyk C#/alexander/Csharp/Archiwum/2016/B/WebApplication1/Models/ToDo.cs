using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ToDo
    {
        public int Id { get; private set; }
        public string Text { get; private set; }
        public DateTime StartDate { get; private set; }

        public ToDo(int id, string text, DateTime startDate)
        {
            this.Id = id;
            this.Text = text;
            this.StartDate = startDate;
        }
    }
}
