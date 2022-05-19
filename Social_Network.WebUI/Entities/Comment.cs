using Social_Network.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Entities
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int PostId { get; set; }
        public virtual CustomIdentityUser User { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
