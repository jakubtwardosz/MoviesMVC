using MoviesMVC.Models;

namespace MoviesMVC.Models
{
    public static class Repository
    {
        public static IList<Movie> repository = new List<Movie>() {
            new Movie()
            {
                Title = "Title",
                Author = "Author",
                Description = "Description",
                ReleaseDate = DateTime.Now,
                BoxOffice = 199999999
            },
            new Movie()
            {
                Title = "Title2",
                Author = "Author2",
                Description = "Description2",
                ReleaseDate = DateTime.Now,
                BoxOffice = 199999992
            },
        };
        public static IEnumerable<Movie> Movies => repository;
        public static void addMovie(Movie movie)
        {
            /*movie.ID = repository.Count() + 1;*/
            repository.Add(movie);
        }

    }
}