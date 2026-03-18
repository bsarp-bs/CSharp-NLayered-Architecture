using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _servicedal;

        public ServiceManager(IServiceDAL servicedal)
        {
            _servicedal = servicedal;
        }

        public void DeleteS(Service entity)
        {
            _servicedal.Delete(entity);
        }

        public List<Service> GetAllS()
        {
            return _servicedal.GetAll();
        }

        public Service GetByIDS(int id)
        {
            return _servicedal.GetByID(id);
        }

        public void InsertS(Service entity)
        {
            _servicedal.Insert(entity);
        }

        public void UpdateS(Service entity)
        {
            _servicedal.Update(entity);
        }
    }
}
