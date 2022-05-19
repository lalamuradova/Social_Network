using Social_Network.Business.Abstact;
using Social_Network.DataAccess.Abstract;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Concrete
{
    public class CommentService : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentService(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }


        public void Add(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void Delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
