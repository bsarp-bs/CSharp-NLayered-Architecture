using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class LocationManager : ILocationService
    {
        ILocationDAL _locationDAL;

        public LocationManager(ILocationDAL locationDAL)
        {
            _locationDAL = locationDAL;
        }

        public void DeleteS(Location entity)
        {
            _locationDAL.Delete(entity);
        }

        public List<Location> GetAllS()
        {
            return _locationDAL.GetAll();
        }

        public Location GetByIDS(int id)
        {
            return _locationDAL.GetByID(id);
        }

        public void InsertS(Location entity)
        {
            _locationDAL.Insert(entity);
        }

        public void UpdateS(Location entity)
        {
            _locationDAL.Update(entity);
        }
    }
}
