using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Berendi_BogdanRazvan_Lab2.Models;

namespace Berendi_BogdanRazvan_Lab2.Data
{
    public class Berendi_BogdanRazvan_Lab2Context : DbContext
    {
        public Berendi_BogdanRazvan_Lab2Context (DbContextOptions<Berendi_BogdanRazvan_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Berendi_BogdanRazvan_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Berendi_BogdanRazvan_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
