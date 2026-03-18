using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class SocialMediaManager : ISocialMediaService
    {
        ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void DeleteS(SocialMedia entity)
        {
            _socialMediaDAL.Delete(entity);
        }

        public List<SocialMedia> GetAllS()
        {
            var value = _socialMediaDAL.GetAll();
            return value;
        }

        public SocialMedia GetByIDS(int id)
        {
            return _socialMediaDAL.GetByID(id);
        }

        public void InsertS(SocialMedia entity)
        {
            _socialMediaDAL.Insert(entity);
        }

        public void UpdateS(SocialMedia entity)
        {
            _socialMediaDAL.Update(entity);
        }
    }
}
