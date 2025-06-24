using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Appointment
    {
        public int AppointmentId { get; set; } // Primary Key
        public int UserId { get; set; } // Customer who booked
        public int VetId { get; set; } // Vet assigned
        public int PetId { get; set; } // Pet being treated
        public DateTime DateTime { get; set; }
        public string Status { get; set; } // (Pending, Confirmed, Cancelled)

        // Navigation Properties
        public User User { get; set; }
        public Vet Vet { get; set; }
        public Pet Pet { get; set; }
    }
}
