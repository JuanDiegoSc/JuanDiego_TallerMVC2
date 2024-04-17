using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuanDiego_TallerMVC2.Models;

namespace JuanDiego_TallerMVC2.Data
{
    public class JuanDiego_TallerMVC2Context : DbContext
    {
        public JuanDiego_TallerMVC2Context (DbContextOptions<JuanDiego_TallerMVC2Context> options)
            : base(options)
        {
        }

        public DbSet<JuanDiego_TallerMVC2.Models.Burger> Burger { get; set; } = default!;
        public DbSet<JuanDiego_TallerMVC2.Models.Promo> Promo { get; set; } = default!;
    }
}
