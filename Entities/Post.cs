using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities
{

    public class Post
    {
        public int PostId { get; set; } // Primary Key
        public int UserId { get; set; } // Author of the post
        public string Content { get; set; }
        public string ImageUrl { get; set; } // Nullable, for images
        public DateTime CreatedAt { get; set; }

        // Navigation Property
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Like> Likes { get; set; }
    }
}
