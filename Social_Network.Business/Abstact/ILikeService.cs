using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstact
{
   public interface ILikeService
    {
        List<Like> GetAll();
        List<Like> GetByUserId(int UserId);
        void Add(Like like);
        void Update(Like like);
        void Delete(Like like);
        Like GetById(int id);
    }
}
