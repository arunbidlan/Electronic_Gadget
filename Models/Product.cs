using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_Gadget.Models
{
    public class Product
    {
          public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        //code to connect the Brand Class with Product Details Class
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        //code to connect the Category Class with Product Details Class
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public IFormFile UploadedFile { get; set; }
    }
}
