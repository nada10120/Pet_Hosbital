using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Comment
    {
        public int CommentId { get; set; } // Primary Key
        public int PostId { get; set; } // Related post
        public int UserId { get; set; } // Comment author
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public Post Post { get; set; }
        public User User { get; set; }
    }

}
