using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{
<<<<<<< HEAD

=======
>>>>>>> da2a9d48ecffaf47b2a082bfa1d31d65dd353904
    public class User
    {
        public int UserId { get; set; } // Primary Key
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Admin, Customer, Vet

        // Navigation Properties
        public List<Appointment> Appointments { get; set; }
        public List<Order> Orders { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
    }
}
