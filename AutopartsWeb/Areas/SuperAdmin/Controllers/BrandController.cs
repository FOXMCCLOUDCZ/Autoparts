using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly ICountryService _countryService;

        public BrandController(IBrandService brandService, ICountryService countryService)
        {
            _brandService = brandService;
            _countryService = countryService;
        }

        private SelectList GetActiveCountries()
        {
            var allCountries = _countryService.AllListAsync().Result;
            var activeCountries = allCountries.Where(co => co.IsActive).ToList();
            return new SelectList(activeCountries, "Id", "CountryNameCZ");
        }

        public async Task<IActionResult> BrandList()
        {
            var brandList = await _brandService.AllListAsync();
            return View(brandList);
        }

        [HttpGet]
        public async Task<IActionResult> CreateBrand()
        {
            ViewData["Country"] = GetActiveCountries();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(BrandCreateVM request)
        {
            await _brandService.CreateBrandAsync(request);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
        }

        [HttpGet]
        public async Task<IActionResult> EditBrand(int id)
        {
            var brand = await _brandService.GetBrandById(id);
            ViewData["Country"] = GetActiveCountries();
            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> EditBrand(BrandEditVM request)
        {
            await _brandService.EditBrandAsync(request);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
        }

        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
        }
    }
}