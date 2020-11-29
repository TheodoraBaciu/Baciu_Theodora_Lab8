using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Baciu_Theodora_Lab8.Models;

namespace Baciu_Theodora_Lab8.Data
{
    public class Baciu_Theodora_Lab8Context : DbContext
    {
        public Baciu_Theodora_Lab8Context (DbContextOptions<Baciu_Theodora_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Baciu_Theodora_Lab8.Models.Book> Book { get; set; }

        public DbSet<Baciu_Theodora_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
