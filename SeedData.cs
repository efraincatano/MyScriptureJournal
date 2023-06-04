using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesMovieContext>>()))
        {
            if (context == null || context.Scripture == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            // Look for any movies.
            if (context.Scripture.Any())
            {
                return;   // DB has been seeded
            }

            context.Scripture.AddRange(
                new Scripture
                {
                    Book = "1 Nephi",
                    ReleaseDate = DateTime.Parse("2023-6-02"),
                    Chapter = 3,
                    Verses = 7,
                    Notes = "God gives us the means to do what he asks of us"
                },

                new Scripture
                {
                    Book = "Mosiah",
                    ReleaseDate = DateTime.Parse("2023-6-02"),
                    Chapter = 2,
                    Verses = 41,
                    Notes = "Obeying the commandments is the key to being happy"
                }
            );
            context.SaveChanges();
        }
    }
}