using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieTrackerBlazor.Shared;

namespace MovieTrackerBlazor.Server.Data
{
    public class MovieTrackerBlazorServerContext : DbContext
    {
        public MovieTrackerBlazorServerContext (DbContextOptions<MovieTrackerBlazorServerContext> options)
            : base(options)
        {
        }

        public DbSet<MovieTrackerBlazor.Shared.Genre> Genre { get; set; } = default!;

        public DbSet<MovieTrackerBlazor.Shared.Movie> Movie { get; set; }
    }
}
