using System.Text.Json;
using IdentityModel.Client;
using Movies.Client.Models;
using Movies.Client.Services.Interfaces;

namespace Movies.Client.Services
{
    public class MovieApiManager : IMovieApiService
    {
        private IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public MovieApiManager(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public Task<Movie> Create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> Get()
        {
            var httpClient = _httpClientFactory.CreateClient("MoviesApiClient");

            var request = new HttpRequestMessage(HttpMethod.Get, string.Empty);

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            var movies = JsonSerializer.Deserialize<List<Movie>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return movies;
        }

        public Task<Movie> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}