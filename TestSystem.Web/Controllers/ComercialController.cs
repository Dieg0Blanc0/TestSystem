using Microsoft.AspNetCore.Mvc;
using TestSystem.Core.DTOs;
using TestSystem.Core.Interfaces.Services;

namespace TestSystem.Web.Controllers
{
    public class ComercialController : Controller
    {
        private readonly ICaoUsuarioService _caoUsuarioService;
        private readonly ICaoFaturaService _caoFaturaService;

        public ComercialController(ICaoUsuarioService caoUsuarioService,
            ICaoFaturaService caoFaturaService)
        {
            _caoUsuarioService = caoUsuarioService;
            _caoFaturaService = caoFaturaService;
        }

        public async Task<IActionResult> PerformanceComercial()
        {
            var result = await _caoUsuarioService.GetAllCaoUsuarioWithPermisionAsync();

            return View(result);
        }

        public async Task<IActionResult> GetProfit(PerformanceComercialDTO viewModel)
        {
            var fromDate = DateOnly.Parse(viewModel.FromDate);
            var date = (DateTime.Parse(viewModel.ToDate));
            var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var toDate = DateOnly.FromDateTime(date.AddDays(daysInMonth - 1));


            var Invoices = await _caoFaturaService.GetProfitAsync(viewModel.Consultors.ToList(), fromDate, toDate);


            return View("_ProfitPartialView", Invoices);
        }

        public async Task<IActionResult> GetProfitJson(PerformanceComercialDTO viewModel)
        {
            var fromDate = DateOnly.Parse(viewModel.FromDate);
            var date = (DateTime.Parse(viewModel.ToDate));
            var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
            var toDate = DateOnly.FromDateTime(date.AddDays(daysInMonth - 1));


            var Invoices = await _caoFaturaService.GetProfitAsync(viewModel.Consultors.ToList(), fromDate, toDate);


            return Json(Invoices);
        }
    }
}
