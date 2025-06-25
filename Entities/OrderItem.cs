using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class OrderItem
    {
        public int OrderItemId { get; set; } // Primary Key
        public int OrderId { get; set; } // Reference to the Order
        public int ProductId { get; set; } // Reference to Product
        public int Quantity { get; set; }
        public decimal Price { get; set; } // Unit price at the time of order

        // Navigation Properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }

}
