using Microsoft.EntityFrameworkCore;
using MovieApp.Data;

namespace MovieApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieAppContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;   
                }

                context.Movie.AddRange(
                      new Movie
                      {
                          Name = "The Godfather",
                          Description = "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American Corleone crime family. When organized crime family patriarch, Vito Corleone barely survives an attempt on his life, his youngest son, Michael steps in to take care of the would-be killers, launching a campaign of bloody revenge.",
                          ReleaseYear = 1972,
                      },
                      new Movie
                      {

                          Name = "The Lord of the Rings: The Fellowship of the Ring",
                          Description = "Young hobbit Frodo Baggins, after inheriting a mysterious ring from his uncle Bilbo, must leave his home in order to keep it from falling into the hands of its evil creator. Along the way, a fellowship is formed to protect the ringbearer and make sure that the ring arrives at its final destination: Mt. Doom, the only place where it can be destroyed.",
                          ReleaseYear = 2001,
                      },
                      new Movie
                      {
                          Name = "Napoleon Dynamite",
                          Description = "A listless and alienated teenager decides to help his new friend win the class presidency in their small western high school, while he must deal with his bizarre family life back home.",
                          ReleaseYear = 2004
                      },
                       new Movie
                       {
                           Name = "The Lion King",
                           Description = "A young lion prince is cast out of his pride by his cruel uncle, who claims he killed his father. While the uncle rules with an iron paw, the prince grows up beyond the Savannah, living by a philosophy: No worries for the rest of your days. But when his past comes to haunt him, the young prince must decide his fate: Will he remain an outcast or face his demons and become what he needs to be?",
                           ReleaseYear = 1994
                       },
                       new Movie
                       {
                           Name = "Beetlejuice",
                           Description = "After an untimely death, a newly dead New England couple seek help from a deranged demon exorcist to scare an affluent New York family out of their home.",
                           ReleaseYear = 1988
                       },
                       new Movie
                       {
                           Name = "Once Upon a Time in...Hollywood",
                           Description = "Los Angeles, 1969. TV star Rick Dalton, a struggling actor specializing in westerns, and stuntman Cliff Booth, his best friend, try to survive in a constantly changing movie industry. Dalton is the neighbor of the young and promising actress and model Sharon Tate, who has just married the prestigious Polish director Roman Polanski…",
                           ReleaseYear = 2019
                       },
                       new Movie
                       {
                           Name = "Test Movie 1",
                           Description = "Description 1",
                           ReleaseYear = 2001
                       },
                    new Movie
                    {
                        Name = "Test Movie 2",
                        Description = "Description 2",
                        ReleaseYear = 2002
                    },
                    new Movie
                    {
                        Name = "Test Movie 3",
                        Description = "Description 3",
                        ReleaseYear = 2003
                    },
                    new Movie
                    {
                        Name = "Test Movie 4",
                        Description = "Description 4",
                        ReleaseYear = 2004
                    },
                    new Movie
                    {
                        Name = "Test Movie 5",
                        Description = "Description 5",
                        ReleaseYear = 2005
                    },
                    new Movie
                    {
                        Name = "Test Movie 6",
                        Description = "Description 6",
                        ReleaseYear = 2006
                    },
                    new Movie
                    {
                        Name = "Test Movie 7",
                        Description = "Description 7",
                        ReleaseYear = 2007
                    }, new Movie
                    {
                        Name = "Test Movie 8",
                        Description = "Description 8",
                        ReleaseYear = 2008
                    }, new Movie
                    {
                        Name = "Test Movie 9",
                        Description = "Description 9",
                        ReleaseYear = 2009
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}