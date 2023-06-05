using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ToDoController : Controller
    {
        private IToDoService toDoService;

        public ToDoController(IToDoService toDoService)
        {
            this.toDoService = toDoService;
        }

        public IActionResult Index()
        {
            List<ToDo> todoS = toDoService.GetAll();
            return View(todoS);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string text)
        {
            toDoService.Add(text);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            toDoService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
