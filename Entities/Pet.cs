using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Pet
    {
        public int PetId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Type { get; set; } // (Dog, Cat, etc.)
        public int Age { get; set; }

        // Foreign Key - UserId (Owner)
        public int UserId { get; set; }
        public User Owner { get; set; } // Navigation property

        // Navigation Property
        public List<Appointment> Appointments { get; set; }
    }

}
