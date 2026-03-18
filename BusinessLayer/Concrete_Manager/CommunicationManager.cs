using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class CommunicationManager : ICommunicationService
    {
        ICommunicationDAL _communicationDAL;

        public CommunicationManager(ICommunicationDAL communicationDAL)
        {
            _communicationDAL = communicationDAL;
        }

        public void DeleteS(Communication entity)
        {
            _communicationDAL.Delete(entity);
        }

        public List<Communication> GetAllS()
        {
            return _communicationDAL.GetAll();
        }

        public Communication GetByIDS(int id)
        {
            var value = _communicationDAL.GetByID(id);
            return value;
        }

        public void InsertS(Communication entity)
        {
            _communicationDAL.Insert(entity);
        }

        public void UpdateS(Communication entity)
        {
            _communicationDAL.Update(entity);
        }
    }
}
