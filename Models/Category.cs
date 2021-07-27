using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_Gadget.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Product { get; set; }

        public string Item_Category { get; set; }
    }
}
