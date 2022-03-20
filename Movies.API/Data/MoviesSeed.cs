using Movies.API.Models;

namespace Movies.API.Data
{
    public static class MoviesSeed
    {
        public static async Task SeedContextAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<MoviesDbContext>();

            if (!context.Movies.Any())
            {
                var movies = new List<Movie>
                {
                    new Movie
                    {
                        Id = 1,
                        Genre = "Drama",
                        Title = "The Shawshank Redemption",
                        Rating = "9.3",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1994, 5, 5),
                        Owner = "alice"
                    },
                    new Movie
                    {
                        Id = 2,
                        Genre = "Crime",
                        Title = "The Godfather",
                        Rating = "9.2",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1972, 5, 5),
                        Owner = "alice"
                    },
                    new Movie
                    {
                        Id = 3,
                        Genre = "Action",
                        Title = "The Dark Knight",
                        Rating = "9.1",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(2008, 5, 5),
                        Owner = "bob"
                    },
                    new Movie
                    {
                        Id = 4,
                        Genre = "Crime",
                        Title = "12 Angry Men",
                        Rating = "8.9",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1957, 5, 5),
                        Owner = "bob"
                    },
                    new Movie
                    {
                        Id = 5,
                        Genre = "Biography",
                        Title = "Schindler's List",
                        Rating = "8.9",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1993, 5, 5),
                        Owner = "alice"
                    },
                    new Movie
                    {
                        Id = 6,
                        Genre = "Drama",
                        Title = "Pulp Fiction",
                        Rating = "8.9",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1994, 5, 5),
                        Owner = "alice"
                    },
                    new Movie
                    {
                        Id = 7,
                        Genre = "Drama",
                        Title = "Fight Club",
                        Rating = "8.8",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1999, 5, 5),
                        Owner = "bob"
                    },
                    new Movie
                    {
                        Id = 8,
                        Genre = "Romance",
                        Title = "Forrest Gump",
                        Rating = "8.8",
                        ImageUrl = "images/src",
                        ReleasedOn = new DateTime(1994, 5, 5),
                        Owner = "bob"
                    }
                };
                await context.Movies.AddRangeAsync(movies);
                await context.SaveChangesAsync();
            }
        }
    }
}