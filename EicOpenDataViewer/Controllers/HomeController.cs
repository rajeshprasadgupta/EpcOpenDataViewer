using EicOpenDataViewer.Models;
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
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            string email = configuration.GetSection("Api:Email").Value;
            string apiKey = configuration.GetSection("Api:ApiKey").Value;
            _pageSize = int.Parse(configuration.GetSection("Api:PageSize").Value);
            _filterUrl = configuration.GetSection("Api:FilterUrl").Value;
            _recommendationUrl = configuration.GetSection("Api:RecommendationUrl").Value;
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(email + ":" + apiKey);
            _apiKey = System.Convert.ToBase64String(toEncodeAsBytes);
        }


        [HttpGet]
        public async Task<IActionResult> Recommendation(string lmkkey)
        {

            Recommendations recommendations = new Recommendations();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _apiKey);
                var url = _recommendationUrl + lmkkey;
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != "Resource not found." && response.StatusCode == HttpStatusCode.OK)
                        recommendations = JsonConvert.DeserializeObject<Recommendations>(apiResponse);
                }
            }
            return View(recommendations.Rows);
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
            int from = 1;
            if (page > 1) from = ((page - 1) * _pageSize) + 1;
            ViewBag.CurrentFilterCriteria = selectedValue;
            ViewBag.CurrentFilterString = searchString;
            ViewBag.PreviousFilterString = searchString;
            string pageQuery = $"&size={_pageSize}&from={from}";
            string subquery = selectedValue + "=" + searchString + pageQuery;

            PublicBuildings buildings = new PublicBuildings();
            if (searchString == null)
                return View(new PaginatedList<PublicBuilding>(buildings.Rows, page, _pageSize));
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", _apiKey);
                var url = _filterUrl + subquery;
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(apiResponse) && response.StatusCode == HttpStatusCode.OK)
                        buildings = JsonConvert.DeserializeObject<PublicBuildings>(apiResponse);
                }
            }

            return View(new PaginatedList<PublicBuilding>(buildings.Rows, page, _pageSize));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}