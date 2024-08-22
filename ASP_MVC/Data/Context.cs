using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_MVC.Models;

namespace MvcMovie.Data.MvcMovie
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<ASP_MVC.Models.Movie> Movie { get; set; } = default!;
    }
}
