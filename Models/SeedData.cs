using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoviesMVC.Controllers;
using MoviesMVC.Data;
using System;
using System.Linq;

namespace MoviesMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }
            

            var romantic = new Genre { Name = "Romance" };
            var comedy = new Genre { Name = "Comedy" };
            var western = new Genre { Name = "Western" };

            context.Genres.AddRange(romantic, comedy, western);
            context.SaveChanges();

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "O Brother, Where Art Thou?",
                        Author = "Coen Brothers",
                        Description = "In the deep south during the 1930s, three escaped convicts search for hidden treasure while a relentless lawman pursues them. On their journey they come across many comical characters and incredible situations. Based upon Homer's 'Odyssey'.",
                        ReleaseDate = new DateTime(2001, 04, 06),
                        Genre = romantic,
                        BoxOffice = 71868327,
                        Rating = Rating.FOUR
                    },
                    new Movie
                    {
                        Title = "Sneakers",
                        Author = "Phil Alden Robinson",
                        Description = "When shadowy U.S. intelligence agents blackmail a reformed computer hacker and his eccentric team of security experts into stealing a code-breaking 'black box' from a Soviet-funded genius, they uncover a bigger conspiracy. Now, he and his 'sneakers' must save themselves and the world economy by retrieving the box from their blackmailers.",
                        ReleaseDate = new DateTime(1992, 09, 09),
                        Genre = western,
                        BoxOffice = 105232691,
                        Rating = Rating.FIVE
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        Author = "Ivan Reitman",
                        Description = "Three parapsychologists forced out of their university funding set up shop as a unique ghost removal service in New York City, attracting frightened yet skeptical customers.",
                        ReleaseDate = new DateTime(1984, 06, 07),
                        Genre = comedy,
                        BoxOffice = 2952000,
                        Rating = Rating.FIVE
                    },
                    new Movie
                    {
                        Title = "Gremlins",
                        Author = "Joe Dante",
                        Description = "A young man inadvertently breaks three important rules concerning his new pet and unleashes a horde of malevolently mischievous monsters on a small town.",
                        ReleaseDate = new DateTime(1984, 06, 08),
                        Genre = comedy,
                        BoxOffice = 3842000,
                        Rating = Rating.FIVE
                    }
                );

            context.SaveChanges();

            }

        }
    }
}
