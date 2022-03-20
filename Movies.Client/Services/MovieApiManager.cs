using Movies.Client.Models;
using Movies.Client.Services.Interfaces;

namespace Movies.Client.Services
{
    public class MovieApiManager : IMovieApiService
    {
        public Task<Movie> Create(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> Get()
        {
            throw new NotImplementedException();
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