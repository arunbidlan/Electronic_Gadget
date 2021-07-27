using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Electronic_Gadget.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }

        public decimal Discount { get; set; }


        //code to connect the customer class with order class
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        //code to connect the product class with order class
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
