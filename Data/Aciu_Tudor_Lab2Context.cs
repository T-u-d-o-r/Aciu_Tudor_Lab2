using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aciu_Tudor_Lab2.Models;

namespace Aciu_Tudor_Lab2.Data
{
    public class Aciu_Tudor_Lab2Context : DbContext
    {
        public Aciu_Tudor_Lab2Context (DbContextOptions<Aciu_Tudor_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Aciu_Tudor_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Aciu_Tudor_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
