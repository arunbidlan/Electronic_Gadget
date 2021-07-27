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
    public class IndexModel : PageModel
    {
        private readonly Electronic_Gadget.Data.Electronic_GadgetContext _context;

        public IndexModel(Electronic_Gadget.Data.Electronic_GadgetContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Brand)
                .Include(p => p.Category).ToListAsync();
        }
    }
}
