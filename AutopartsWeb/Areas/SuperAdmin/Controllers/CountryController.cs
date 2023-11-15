using AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Drawing.Text;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        // test
        private readonly ICurrencyService _currencyService;

        public SelectList CurrencyTest;

        public CountryController(ICountryService countryService, ICurrencyService currencyService)
        {
            _countryService = countryService;
            _currencyService = currencyService;
        }

        public async Task<IActionResult> CountryList()
        {
            var countryList = await _countryService.AllListAsync();

            return View(countryList);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCountry()
        {
            //ViewData["Currency"] = await _currencyService.AllListAsync();
            CurrencyTest = new SelectList(await _currencyService.AllListAsync(), "Id", "CurrencyName");
            ViewData["Currency"] = CurrencyTest;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCountry(CountryCreateVM request)
        {
            await _countryService.CreateCountryAsync(request);
            return RedirectToAction("CountryList", "Country", new { Area = ("SuperAdmin") });
        }

        [HttpGet]
        public async Task<IActionResult> EditCountry(int id)
        {
            var country = await _countryService.GetCountryById(id);
            return View(country);
        }

        [HttpPost]
        public async Task<IActionResult> EditCountry(CountryEditVM request)
        {
            await _countryService.EditCountryAsync(request);
            return RedirectToAction("CountryList", "Country", new { Area = ("SuperAdmin") });
        }

        public async Task<IActionResult> DeleteCountry(int id)
        {
            await _countryService.DeleteCountryAsync(id);
            return RedirectToAction("CountryList", "Country", new { Area = ("SuperAdmin") });
        }
    }
}