using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Data;
using System;
using System.Linq;


namespace WebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAppContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }
                context.Users.AddRange(
                    new Users
                    {
                        Name = "Adam",
                        Surname = "Nowak",
                        DateOfBirth = DateTime.Parse("1984-04-25"),
                        login = "adamnowak@crm.com"        
                    },
                    new Users
                    {
                        Name = "Michał",
                        Surname = "Lewandowski",
                        DateOfBirth = DateTime.Parse("1989-06-14"),
                        login = "michallewandowski@crm.com"
                    },
                    new Users
                    {
                        Name = "Jerzy",
                        Surname = "Czerniak",
                        DateOfBirth = DateTime.Parse("1990-11-30"),
                        login = "jerzyczerniak@crm.com"
                    },
                    new Users
                    {
                        Name = "Adrian",
                        Surname = "Kowalski",
                        DateOfBirth = DateTime.Parse("1979-01-01"),
                        login = "adriankowalski@crm.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
