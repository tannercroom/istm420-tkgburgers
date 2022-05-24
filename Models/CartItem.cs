using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team2.Models
{
    public class CartItem
    {
        [Key]
        public int CartID { get; set; }
        public string ProductName { get; set; }
        public string ProductPhoto { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal { get; set; }
    }
}
