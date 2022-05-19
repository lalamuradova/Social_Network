using Social_Network.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Entities
{
    public class Post:IEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual CustomIdentityUser User { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
