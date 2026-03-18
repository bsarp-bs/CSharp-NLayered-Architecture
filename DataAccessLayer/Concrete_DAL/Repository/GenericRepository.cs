using DataAccessLayer.Abstract;
using DataAccessLayer.DAL_Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DataAccessLayer.Concrete_DAL.Repository
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class, new()
    {
        
        public void Delete(T entity)
        {
            using Context _context = new Context();

            _context.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using Context _context = new Context();

            var l = _context.Set<T>().ToList();

            return l;
        }

        public T GetByID(int id)
        {
            using Context _context = new Context();

            var value = _context.Set<T>().Find(id);

            return value;
        }

        public void Insert(T entity)
        {
            using Context _context = new Context();

            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            using Context _context = new Context();

            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
