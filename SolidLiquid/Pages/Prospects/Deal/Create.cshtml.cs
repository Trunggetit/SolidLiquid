using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SolidLiquid.Data;
using SolidLiquid.Models;

namespace SolidLiquid.Pages.Prospects.Deal
{
    public class CreateModel : PageModel
    {
        private readonly SolidLiquid.Models.SolidLiquidContext _context;

        public CreateModel(SolidLiquid.Models.SolidLiquidContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Deals Deals { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Deals.Add(Deals);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}