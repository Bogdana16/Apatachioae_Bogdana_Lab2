using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apatachioae_Bogdana_Lab2.Models;

namespace Apatachioae_Bogdana_Lab2.Data
{
    public class Apatachioae_Bogdana_Lab2Context : DbContext
    {
        public Apatachioae_Bogdana_Lab2Context (DbContextOptions<Apatachioae_Bogdana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Apatachioae_Bogdana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Apatachioae_Bogdana_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
