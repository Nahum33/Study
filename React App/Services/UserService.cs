using React_App.Models;
using System.Net;
using System.Net.Http;
using System.Text.Json;

namespace React_App.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<User?> GetUserByIdentifier(string? identifier)
        {
            _httpClient.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("React_App", "1.0"));
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/vnd.github+json"));

            var uri = $"{_httpClient.BaseAddress}users/{identifier}";
            var response = await _httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = await response.Content.ReadAsStreamAsync();
                var user = await JsonSerializer.DeserializeAsync<User>(contentStream, new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                });
                return user;
            }

            return null;
        }
    }
}
