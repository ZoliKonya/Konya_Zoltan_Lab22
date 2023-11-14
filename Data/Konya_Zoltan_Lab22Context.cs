using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Konya_Zoltan_Lab22.Models;

namespace Konya_Zoltan_Lab22.Data
{
    public class Konya_Zoltan_Lab22Context : DbContext
    {
        public Konya_Zoltan_Lab22Context (DbContextOptions<Konya_Zoltan_Lab22Context> options)
            : base(options)
        {
        }

        public DbSet<Konya_Zoltan_Lab22.Models.Book> Book { get; set; } = default!;

        public DbSet<Konya_Zoltan_Lab22.Models.Publisher>? Publisher { get; set; }

        public DbSet<Konya_Zoltan_Lab22.Models.Author>? Author { get; set; }
    }
}
