using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SolidLiquid.Data;
using SolidLiquid.Models;

namespace SolidLiquid.Pages.Prospects.Deal
{
    public class DetailsModel : PageModel
    {
        private readonly SolidLiquid.Models.SolidLiquidContext _context;

        public DetailsModel(SolidLiquid.Models.SolidLiquidContext context)
        {
            _context = context;
        }

        public Deals Deals { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Deals = await _context.Deals.SingleOrDefaultAsync(m => m.Id == id);

            if (Deals == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
