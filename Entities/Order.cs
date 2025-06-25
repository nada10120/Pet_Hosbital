using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Order
    {
        public int OrderId { get; set; } // Primary Key
        public int UserId { get; set; } // Customer who made the order
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } // (Pending, Completed, Cancelled)

        // Navigation Property
        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }


}
