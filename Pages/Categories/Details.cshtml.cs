using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Electronic_Gadget.Data;
using Electronic_Gadget.Models;

namespace Electronic_Gadget.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Electronic_Gadget.Data.Electronic_GadgetContext _context;

        public DetailsModel(Electronic_Gadget.Data.Electronic_GadgetContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
