using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class ImageManager : IImagesService
    {
        IImagesDAL _imagesDAL;

        public ImageManager(IImagesDAL imagesDAL)
        {
            _imagesDAL = imagesDAL;
        }

        public void DeleteS(Images entity)
        {
            _imagesDAL.Delete(entity);
        }

        public List<Images> GetAllS()
        {
            return _imagesDAL.GetAll();
        }

        public Images GetByIDS(int id)
        {
            return _imagesDAL.GetByID(id);
        }

        public void InsertS(Images entity)
        {
           _imagesDAL.Insert(entity);
        }

        public void UpdateS(Images entity)
        {
            _imagesDAL.Update(entity);
        }
    }
}
