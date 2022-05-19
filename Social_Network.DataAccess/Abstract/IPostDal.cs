using Social_Network.Core.DataAccess;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.DataAccess.Abstract
{
   public interface IPostDal:IEntityRepository<Post>
    {
    }
}
