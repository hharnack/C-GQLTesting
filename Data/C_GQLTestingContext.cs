using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C_GQLTesting.Models;

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
