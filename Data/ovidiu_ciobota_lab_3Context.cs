using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ovidiu_ciobota_lab_3.Models;

namespace ovidiu_ciobota_lab_3.Data
{
    public class ovidiu_ciobota_lab_3Context : DbContext
    {
        public ovidiu_ciobota_lab_3Context (DbContextOptions<ovidiu_ciobota_lab_3Context> options)
            : base(options)
        {
        }

        public DbSet<ovidiu_ciobota_lab_3.Models.Book> Book { get; set; } = default!;

        public DbSet<ovidiu_ciobota_lab_3.Models.Publisher> Publisher { get; set; }

        public DbSet<ovidiu_ciobota_lab_3.Models.Category> Category { get; set; }
    }
}
