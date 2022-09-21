using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestSystem.Core.DTOs;
using TestSystem.Core.Interfaces.Services;
using TestSystem.Core.Response;
using TestSystem.Web.Models;

namespace TestSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}