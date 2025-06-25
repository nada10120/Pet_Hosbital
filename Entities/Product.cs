using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
<<<<<<< HEAD

=======
>>>>>>> da2a9d48ecffaf47b2a082bfa1d31d65dd353904
    public class Product
    {
        public int ProductId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        // Foreign Key to Category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Navigation Property
        public List<OrderItem> OrderItems { get; set; }
    }


---
}
