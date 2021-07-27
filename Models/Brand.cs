using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_Gadget.Models
{
    public class Brand
    {

        public int Id { get; set; }

        [Required]
        public string Brand_Name { get; set; }

        public string Location { get; set; }

        public string Email { get; set; }
    }
}
