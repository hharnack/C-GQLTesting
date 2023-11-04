using Microsoft.EntityFrameworkCore;

namespace C_GQLTesting.Data
{
    public class C_GQLTestingContext : DbContext
    {
        public C_GQLTestingContext (DbContextOptions<C_GQLTestingContext> options)
            : base(options)
        {
        }

        public DbSet<C_GQLTesting.Models.Person> Person { get; set; } = default!;
    }
}
