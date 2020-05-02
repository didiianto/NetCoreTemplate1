using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreTemplate1.Models;

namespace NetCoreTemplate1.Data
{
    public class NetCoreTemplate1Context : DbContext
    {
        public NetCoreTemplate1Context (DbContextOptions<NetCoreTemplate1Context> options)
            : base(options)
        {
        }

        public DbSet<NetCoreTemplate1.Models.Movie> Movie { get; set; }
    }
}
