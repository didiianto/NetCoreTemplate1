using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NetCoreTemplate1.Data;
using NetCoreTemplate1.Models;

namespace NetCoreTemplate1
{
    public class IndexModel : PageModel
    {
        private readonly NetCoreTemplate1.Data.NetCoreTemplate1Context _context;

        public IndexModel(NetCoreTemplate1.Data.NetCoreTemplate1Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
