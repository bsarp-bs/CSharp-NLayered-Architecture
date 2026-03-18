using BusinessLayer.Abstract_Services_;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete_Manager
{
    public class JournalManager : IJournalService
    {
        IJournalDAL _journalDAL;

        public JournalManager(IJournalDAL journalDAL)
        {
            _journalDAL = journalDAL;
        }

        public void DeleteS(Journal entity)
        {
            _journalDAL.Delete(entity);
        }

        public List<Journal> GetAllS()
        {
            return _journalDAL.GetAll();
        }

        public Journal GetByIDS(int id)
        {
            return _journalDAL.GetByID(id);
        }

        public void InsertS(Journal entity)
        {
            _journalDAL.Insert(entity);
        }

        public void UpdateS(Journal entity)
        {
            _journalDAL.Update(entity);
        }
    }
}
