using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class,new ()
    {
        // new()'in anlamı ise bu ınterface kullanılarak oluşturulacak sınıfların parametresiz constructor'ı olması gerektiğidir.

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll();

        T GetByID (int id);


    }
}
