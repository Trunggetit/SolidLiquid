using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SolidLiquid.Data;
using SolidLiquid.Models;

namespace SolidLiquid.Pages.Prospects.Deal
{
    public class EditModel : PageModel
    {
        private readonly SolidLiquid.Models.SolidLiquidContext _context;

        public EditModel(SolidLiquid.Models.SolidLiquidContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Deals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DealsExists(Deals.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DealsExists(int id)
        {
            return _context.Deals.Any(e => e.Id == id);
        }
    }
}
