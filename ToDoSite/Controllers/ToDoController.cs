using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoSite.Models;

namespace ToDoSite.Controllers
{
    public class ToDoController : Controller
    {
        public List<ToDoModel> Actions { get; set; }
        public ToDoController()
        {
            Actions = new List<ToDoModel>() { new ToDoModel() { Title = "Kupit slona", DoneDate = DateTime.Now, ToDate = DateTime.Now.AddDays(33), FromDate = DateTime.Now - TimeSpan.FromDays(12) }, new ToDoModel() { Title = "Pokormit slona", DoneDate = DateTime.Now.AddDays(2), ToDate = DateTime.Now.AddDays(33), FromDate = DateTime.Now - TimeSpan.FromDays(12) }, new ToDoModel() { Title = "Pokormit slon2", DoneDate = DateTime.Now.AddDays(2), ToDate = DateTime.Now.AddDays(33), FromDate = DateTime.Now - TimeSpan.FromDays(12) } };
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(Actions);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ToDoModel model)
        {
            Actions.Add(model);
            return View();
        }
    }
}
