using Social_Network.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social_Network.WebUI.Entities
{
    public class Like:IEntity
    {
        public int Id { get; set; }
        public string   UserId { get; set; }
        public CustomIdentityUser User { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
