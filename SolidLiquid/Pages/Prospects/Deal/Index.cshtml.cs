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
    public class IndexModel : PageModel
    {
        private readonly SolidLiquid.Models.SolidLiquidContext _context;

        public IndexModel(SolidLiquid.Models.SolidLiquidContext context)
        {
            _context = context;
        }

        public IList<Deals> Deals { get;set; }

        public async Task OnGetAsync(int? Id)
        {
            Deals = await _context.Deals.Where(x => x.ClientID == Id).ToListAsync();
        }
    }
}
