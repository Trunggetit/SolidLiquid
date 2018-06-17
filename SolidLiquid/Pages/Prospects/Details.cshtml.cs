using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SolidLiquid.Data;
using SolidLiquid.Models;

namespace SolidLiquid.Pages.Prospects
{
    public class DetailsModel : PageModel
    {
        private readonly SolidLiquid.Models.SolidLiquidContext _context;

        public DetailsModel(SolidLiquid.Models.SolidLiquidContext context)
        {
            _context = context;
        }

        public Clients Clients { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Clients = await _context.Clients.SingleOrDefaultAsync(m => m.Id == id);

            if (Clients == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
