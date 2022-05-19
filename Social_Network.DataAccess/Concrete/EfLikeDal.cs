using Social_Network.Core.DataAccess.EntityFramework;
using Social_Network.DataAccess.Abstract;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.DataAccess.Concrete
{
   public class EfLikeDal: EfEntityRepositoryBase<Like, SocialDbContext>, ILikeDal
    {
    }
}
