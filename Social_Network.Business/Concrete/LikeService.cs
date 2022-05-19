using Social_Network.Business.Abstact;
using Social_Network.DataAccess.Abstract;
using Social_Network.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Social_Network.Business.Concrete
{
    public class LikeService : ILikeService
    {
        private ILikeDal _likeDal;

        public LikeService(ILikeDal likeDal)
        {
            _likeDal = likeDal;
        }

        public void Add(Like like)
        {
            _likeDal.Add(like);
        }

        public void Delete(Like like)
        {
            throw new NotImplementedException();
        }

        public List<Like> GetAll()
        {
            throw new NotImplementedException();
        }

        public Like GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Like> GetByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public void Update(Like like)
        {
            throw new NotImplementedException();
        }
    }
}
