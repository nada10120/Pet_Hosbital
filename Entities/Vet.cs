using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Vet
    {
        public int VetId { get; set; } // Primary Key
        public int UserId { get; set; } // Vet user account
        public string Speciality { get; set; } // Veterinarian Specialization

        // Navigation Property
        public List<Appointment> Appointments { get; set; }
    }
}
