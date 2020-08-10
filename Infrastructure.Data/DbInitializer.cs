using System;
using System.Linq;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Data
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using (var context = new BooksContext(
                serviceProvider.GetRequiredService<DbContextOptions<BooksContext>>()))
            {
                if (context.books.Any())
                {
                    return;
                }

                context.books.AddRange(
                    new Book
                    {
                        id = 1,
                        type = BookType.Detective,
                        price = 78.4M,
                        pages = 482,
                        name = "Sherlock Holmes",
                        isActive = true
                    },
                    new Book
                    {
                        id = 2,
                        type = BookType.Classics,
                        price = 125.4M,
                        pages = 546,
                        name = "Pride and Prejudice ",
                        isActive = true
                    },
                    new Book
                    {
                        id = 3,
                        type = BookType.Mystery,
                        price = 34.3M,
                        pages = 134,
                        name = "the silent patient",
                        isActive = true
                    },
                    new Book
                    {
                        id = 4,
                        type = BookType.Fantasy,
                        price = 19.4M,
                        pages = 552,
                        name = "THE NAME OF THE WIND ",
                        isActive = true
                    },
                    new Book
                    {
                        id = 5,
                        type = BookType.Fantasy,
                        price = 59.4M,
                        pages = 242,
                        name = "WAY OF KINGS ",
                        isActive = true
                    },
                    new Book
                    {
                        id = 6,
                        type = BookType.Fantasy,
                        price = 15.4M,
                        pages = 134,
                        name = "A WIZARD OF EARTHSEA",
                        isActive = true
                    },
                    new Book
                    {
                        id = 7,
                        type = BookType.Historical,
                        price = 200.5M,
                        pages = 600,
                        name = "Grant",
                        isActive = true
                    },
                    new Book
                    {
                        id = 8,
                        type = BookType.Historical,
                        price = 339.3M,
                        pages = 357,
                        name = "Guns, Germs, and Steel: The Fate of Human Societies",
                        isActive = true
                    },
                    new Book
                    {
                        id = 9,
                        type = BookType.ActionAndAdventure,
                        price = 14.4M,
                        pages = 412,
                        name = "The Girl Beneath the Sea",
                        isActive = true
                    },
                    new Book
                    {
                        id = 10,
                        type = BookType.ActionAndAdventure,
                        price = 111.4M,
                        pages = 552,
                        name = "Across the Winding River",
                        isActive = true
                    });

                context.SaveChanges();
            }
        }
    }
}
