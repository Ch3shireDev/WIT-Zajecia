using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IToDoService
    {
        void Add(string text);
        List<ToDo> GetAll();
        void Remove(int id);
    }
}
