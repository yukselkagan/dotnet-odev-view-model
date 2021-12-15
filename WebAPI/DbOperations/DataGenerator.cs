using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(
                    new Book
                    {
                        Id = 1,
                        Title = "Robinson Crusoe",
                        GenreId = 1,
                        PageCount = 100,
                        PublishDate = new DateTime(2000, 01, 01)
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Dune",
                        GenreId = 2,
                        PageCount = 200,
                        PublishDate = new DateTime(2002, 01, 01)
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "Space",
                        GenreId = 2,
                        PageCount = 200,
                        PublishDate = new DateTime(2002, 01, 01)
                    }
                );

                context.SaveChanges();


                


            }


        }




    }
}
