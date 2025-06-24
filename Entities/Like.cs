using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Like
    {
        public int LikeId { get; set; } // Primary Key
        public int PostId { get; set; } // Post being liked
        public int UserId { get; set; } // User who liked the post

        // Navigation Properties
        public Post Post { get; set; }
        public User User { get; set; }
    }


}
