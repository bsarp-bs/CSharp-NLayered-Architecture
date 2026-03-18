using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class StaffManager : IStaffService
    {

        private readonly IStaffDAL _staffdal;

        public StaffManager(IStaffDAL staffdal)
        {
            _staffdal = staffdal;
        }

        public void DeleteS(Staff entity)
        {
            _staffdal.Delete(entity);
        }

        public List<Staff> GetAllS()
        {
            return _staffdal.GetAll();
        }

        public Staff GetByIDS(int id)
        {
           return _staffdal.GetByID(id);

        }

        public void InsertS(Staff entity)
        {
            _staffdal.Insert(entity);
        }

        public void UpdateS(Staff entity)
        {
            _staffdal.Update(entity);
        }
    }
}
