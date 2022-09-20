using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestSystem.Core.DTOs;
using TestSystem.Core.Interfaces;
using TestSystem.Core.Interfaces.Services;
using TestSystem.Core.Response;
using TestSystem.Web.Models;

namespace TestSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICaoUsuarioService _caoUsuarioService;

        public HomeController(ICaoUsuarioService caoUsuarioService)  
        { 
            _caoUsuarioService = caoUsuarioService;
        }
       

        public async Task<IActionResult> Index()
        {
            var caoUsuarios = await _caoUsuarioService.GetAllCaoUsuarioWithPermisionAsync();
            var response = new Response<List<CaoUsuarioDTO>>(caoUsuarios.ToList());

            return View(caoUsuarios);
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