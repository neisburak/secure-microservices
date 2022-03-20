using Movies.Client.Models;

namespace Movies.Client.Services.Interfaces
{
    public interface IMovieApiService
    {
        Task<IEnumerable<Movie>> Get();
        Task<Movie> Get(int id);
        Task<Movie> Create(Movie movie);
        Task<Movie> Update(Movie movie);
        Task Delete(int id);
    }
}