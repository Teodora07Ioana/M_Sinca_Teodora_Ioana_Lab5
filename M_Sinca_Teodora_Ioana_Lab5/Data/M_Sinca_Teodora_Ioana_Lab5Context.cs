using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using M_Sinca_Teodora_Ioana_Lab5.Models;

namespace M_Sinca_Teodora_Ioana_Lab5.Data
{
    public class M_Sinca_Teodora_Ioana_Lab5Context : DbContext
    {
        public M_Sinca_Teodora_Ioana_Lab5Context (DbContextOptions<M_Sinca_Teodora_Ioana_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<M_Sinca_Teodora_Ioana_Lab5.Models.Expenses> Expenses { get; set; } = default!;
    }
}
