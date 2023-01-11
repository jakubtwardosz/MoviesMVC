using MoviesMVC.Models;
using System.Security.Policy;

namespace MoviesMVC.Models
{
    public static class Repository
    {
        public static IList<Movie> repository = new List<Movie>() {
            new Movie()
            {
                Title = "O Brother, Where Art Thou?",
                Author = "Coen Brothers",
                Description = "In the deep south during the 1930s, three escaped convicts search for hidden treasure while a relentless lawman pursues them. On their journey they come across many comical characters and incredible situations. Based upon Homer's 'Odyssey'.",
                ReleaseDate = new DateTime(2001, 04, 06),
                BoxOffice = 71868327,
                Rating = Rating.FOUR
            },
            new Movie()
            {
                Title = "Sneakers",
                Author = "Phil Alden Robinson",
                Description = "When shadowy U.S. intelligence agents blackmail a reformed computer hacker and his eccentric team of security experts into stealing a code-breaking 'black box' from a Soviet-funded genius, they uncover a bigger conspiracy. Now, he and his 'sneakers' must save themselves and the world economy by retrieving the box from their blackmailers.",
                ReleaseDate = new DateTime(1992, 09, 09),
                BoxOffice = 105232691,
                Rating = Rating.FIVE
            },
        };
        public static IEnumerable<Movie> Movies => repository;
        public static void addMovie(Movie movie)
        {
            repository.Add(movie);
        }
        public static void deleteMovie(int id)
        {
            var item = repository.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                repository.Remove(item);
            }
        }

    }
}