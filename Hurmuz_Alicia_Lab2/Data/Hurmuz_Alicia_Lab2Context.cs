using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hurmuz_Alicia_Lab2.Models;

namespace Hurmuz_Alicia_Lab2.Data
{
    public class Hurmuz_Alicia_Lab2Context : DbContext
    {
        public Hurmuz_Alicia_Lab2Context (DbContextOptions<Hurmuz_Alicia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hurmuz_Alicia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Hurmuz_Alicia_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
