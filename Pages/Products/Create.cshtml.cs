using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Electronic_Gadget.Data;
using Electronic_Gadget.Models;
using System.IO;


namespace Electronic_Gadget.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly Electronic_Gadget.Data.Electronic_GadgetContext _context;

        public CreateModel(Electronic_Gadget.Data.Electronic_GadgetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandId"] = new SelectList(_context.Brand, "Id", "Brand_Name");
        ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Product");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Product.UploadedFile != null)
            {
                Product.ImageUrl = Product.UploadedFile.FileName;

                var filePath = "./wwwroot/images/" + Product.UploadedFile.FileName;


                if (Product.UploadedFile.Length > 0)
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        Product.UploadedFile.CopyTo(stream);
                    }
                }
            }

                _context.Product.Add(Product);
            _context.SaveChanges();
          

            return RedirectToPage("./Index");
        }
    }
}
