using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Electronic_Gadget.Data;
using Electronic_Gadget.Models;

namespace Electronic_Gadget.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly Electronic_Gadget.Data.Electronic_GadgetContext _context;

        public DetailsModel(Electronic_Gadget.Data.Electronic_GadgetContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Product).FirstOrDefaultAsync(m => m.Id == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
