using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook.DataAccess
{
    public interface IRepository<T, ID> where T : class
    {
        ID Insert(T entity);
        void Update(T entity);
        ID Delete(T entity);
        ID DeleteById(ID id);
        IEnumerable<T> GetAll();
        T GetById(ID id);
    }
}
