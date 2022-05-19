using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Abstact
{
   public interface ICommentService
    {
        List<Comment> GetAll();
        List<Comment> GetByUserId(int UserId);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        Comment GetById(int id);
    }
}
