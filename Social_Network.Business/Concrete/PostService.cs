
using Social_Network.Business.Abstact;
using Social_Network.DataAccess.Abstract;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Concrete
{
    public class PostService : IPostService
    {
        private IPostDal _postDal;

        public PostService(IPostDal postDal)
        {
            _postDal = postDal;
        }


        public void Add(Post post)
        {
            _postDal.Add(post);
        }

        public void Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
