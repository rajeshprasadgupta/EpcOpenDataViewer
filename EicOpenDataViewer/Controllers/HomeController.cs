using EicOpenDataViewer.Models;
using EicOpenDataViewer.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Http.Headers;
namespace EicOpenDataViewer.Controllers
{
    public class HomeController : Controller
    {
        private string _filterUrl = string.Empty;
        private string _recommendationUrl = string.Empty;
        private readonly ILogger<HomeController> _logger;
        private readonly string _apiKey = string.Empty;
        private int _pageSize = 25;

        public IEpcService EpcService { get; }

        public HomeController(ILogger<HomeController> logger, IEpcService epcService)
        {
            _logger= logger;
            EpcService = epcService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string selectedValue, string searchString, string previousFilter, int page = 1)
        {
            if (previousFilter == null)
            {
                page = 1;
            }
            else if (previousFilter != searchString)
            {
                page = 1;
            }
            ViewBag.CurrentFilterCriteria = selectedValue;
            ViewBag.CurrentFilterString = searchString;
            ViewBag.PreviousFilterString = searchString;
            PublicBuildings buildings = new PublicBuildings();
            if (searchString == null)
                return View(new PaginatedList<PublicBuilding>(buildings.Rows, page, _pageSize));
            buildings = await EpcService.SearchCertificates(selectedValue, searchString, page);

            return View(new PaginatedList<PublicBuilding>(buildings.Rows, page, _pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> Recommendation(string lmkkey)
        {

            var recommendations = await EpcService.GetCertificateRecommendations(lmkkey);
            return View(recommendations.Rows);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}