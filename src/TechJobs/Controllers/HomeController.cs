using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TechJobs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("login", "Login");
            actionChoices.Add("listall", "Listall");
            actionChoices.Add("search", "Search");
            actionChoices.Add("addnew", "Addnew"); 
            actionChoices.Add("filepathbuilder", "Filepathbuilder");
            actionChoices.Add("welcomehome", "Welcomehome");
            ViewBag.actions = actionChoices;

            return View();
        }
    }
}
