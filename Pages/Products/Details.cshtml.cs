using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Electronic_Gadget.Data;
using Electronic_Gadget.Models;

namespace Electronic_Gadget.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly Electronic_Gadget.Data.Electronic_GadgetContext _context;

        public DetailsModel(Electronic_Gadget.Data.Electronic_GadgetContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Brand)
                .Include(p => p.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
