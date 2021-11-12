using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using DemoDotNetMVC;
using DemoDotNetMVC.Models;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDBContext>>()))
            {
                //Look for any Person.
                if (context.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context.Person.AddRange(
                    new Person
                    {
                        PersonId = 001,
                        PersonName = "Person01",
                       
                    },

                    new Person
                    {
                        PersonId = 002,
                        PersonName = "Person02",
                       
                    },

                    new Person
                    {
                        PersonId = 003,
                        PersonName = "Person03",
                    },

                    new Person
                    {
                        PersonId = 004,
                        PersonName = "Person04",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}