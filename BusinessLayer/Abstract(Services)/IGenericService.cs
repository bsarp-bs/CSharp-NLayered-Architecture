using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract_Services_
{
    public interface IGenericService<S> where S : class, new()
    {
        // new()'in anlamı ise bu ınterface kullanılarak oluşturulacak sınıfların parametresiz constructor'ı olması gerektiğidir.

        void InsertS(S entity);

        void UpdateS(S entity);

        void DeleteS(S entity);

        List<S> GetAllS();

        S GetByIDS(int id);

    }
}
