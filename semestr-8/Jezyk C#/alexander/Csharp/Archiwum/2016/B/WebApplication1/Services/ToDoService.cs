using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ToDoService : IToDoService
    {
        private List<ToDo> ToDos;
        private static int IdCounter = 0;

        public ToDoService()
        {
            ToDos = new List<ToDo>();
        }
        public void Add(string text)
        {
            ToDos.Add(new ToDo(++IdCounter, text, DateTime.Now));
        }

        public List<ToDo> GetAll()
        {
            return ToDos;
        }

        public void Remove(int id)
        {
            ToDos.Remove(ToDos.Single(t => t.Id == id));
        }
    }
}
