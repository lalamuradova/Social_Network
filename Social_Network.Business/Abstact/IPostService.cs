using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstact
{
   public interface IPostService
    {
        List<Post> GetAll();
        List<Post> GetByUserId(int UserId);
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
        Post GetById(int id);
    }
}
