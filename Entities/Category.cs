using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Category
    {
        public int CategoryId { get; set; } // Primary Key
        public string Name { get; set; }

        // Navigation Property
        public List<Product> Products { get; set; }
    }


---

}
