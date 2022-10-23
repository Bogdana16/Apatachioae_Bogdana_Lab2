using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Apatachioae_Bogdana_Lab2.Data;
using Apatachioae_Bogdana_Lab2.Models;

namespace Apatachioae_Bogdana_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Apatachioae_Bogdana_Lab2.Data.Apatachioae_Bogdana_Lab2Context _context;

        public IndexModel(Apatachioae_Bogdana_Lab2.Data.Apatachioae_Bogdana_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
