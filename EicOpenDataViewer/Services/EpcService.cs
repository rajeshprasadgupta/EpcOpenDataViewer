using EicOpenDataViewer.Controllers;
using EicOpenDataViewer.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net;
using Microsoft.Net.Http.Headers;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EicOpenDataViewer.Services
{
    public interface IEpcService
    {
        Task<PublicBuildings> SearchCertificates(string searchCriteria, string filter, int pageNumber);
        Task<Recommendations> GetCertificateRecommendations(string lmkkey);
    }
    public class EpcService : IEpcService
    {
        IHttpClientFactory _httpClientFactory;
        private string _filterUrl = string.Empty;
        private string _recommendationUrl = string.Empty;
        private readonly ILogger<HomeController> _logger;
        private readonly string _apiKey = string.Empty;
        private int _pageSize = 25;
        public EpcService(ILogger<HomeController> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            string email = configuration.GetSection("Api:Email").Value;
            string apiKey = configuration.GetSection("Api:ApiKey").Value;
            _pageSize = int.Parse(configuration.GetSection("Api:PageSize").Value);
            _filterUrl = configuration.GetSection("Api:FilterUrl").Value;
            _recommendationUrl = configuration.GetSection("Api:RecommendationUrl").Value;
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(email + ":" + apiKey);
            _apiKey = System.Convert.ToBase64String(toEncodeAsBytes);
            _httpClientFactory = httpClientFactory;
        }
        public async Task<Recommendations> GetCertificateRecommendations(string lmkkey)
        {
            var url = _recommendationUrl + lmkkey;
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", _apiKey);
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            Recommendations recommendations = new Recommendations();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentString =
                    await httpResponseMessage.Content.ReadAsStringAsync();
                if (contentString != "Resource not found.")
                recommendations = JsonConvert.DeserializeObject<Recommendations>(contentString);
            }
            return recommendations;
        }

        public async Task<PublicBuildings> SearchCertificates(string searchCriteria, string filter,  int pageNumber)
        {
            int fromPosition = 1;
            if (pageNumber > 1) fromPosition = ((pageNumber - 1) * _pageSize) + 1;
            string pageQuery = $"&size={_pageSize}&from={fromPosition}";
            string subquery = searchCriteria + "=" + filter + pageQuery;
            var url = _filterUrl + subquery;
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Basic", _apiKey);
            var httpClient = _httpClientFactory.CreateClient();
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            PublicBuildings buildings = new PublicBuildings();
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var contentString =
                    await httpResponseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(contentString))
                    buildings = JsonConvert.DeserializeObject<PublicBuildings>(contentString);
            }
            return buildings;
        }
    }
}
