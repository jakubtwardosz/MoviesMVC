using MoviesMVC.Models;

namespace MoviesMVC.Models
{
    public static class Repository
    {
        public static IList<Movie> repository = new List<Movie>() {
            new Movie()
            {
                ID= 1,
                Title = "Hello World",
                PosterUrl = "HELLOWORLD.jpg",
                Director = "Director",
                Description = "Description"
            },
            new Movie()
            {
                ID= 2,
                Title = "Goodbye World",
                PosterUrl = "GoodbyeWORLD.jpg",
                Director = "Director",
                Description = "Description"
            }
        };
        public static IEnumerable<Movie> Movies => repository;
        public static void addMovie(Movie movie)
        {
            movie.ID = repository.Count() + 1;
            repository.Add(movie);
        }

    }
}