using Microsoft.EntityFrameworkCore;
using C_GQLTesting.Data;

namespace C_GQLTesting.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new C_GQLTestingContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<C_GQLTestingContext>>()))
        {
            // Look for any people.
            if (context.Person.Any())
            {
                return;   // DB has been seeded
            }
            context.Person.AddRange(
                new Person
                {
                    FirstName = "Jim",
                    LastName = "Bob",
                    Age = 40,
                },
                new Person
                {
                    FirstName = "Sally",
                    LastName = "Hansen",
                    Age = 64,
                },
                new Person
                {
                    FirstName = "Jerry",
                    LastName = "Smith",
                    Age = 18,
                },
                new Person
                {
                    FirstName = "Tiffany",
                    LastName = "Black",
                    Age = 33,
                }
            );
            context.SaveChanges();
        }
    }
}
