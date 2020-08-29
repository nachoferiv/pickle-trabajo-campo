using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFTP1.Interfaces
{
    public interface ICrud<T> where T:IEntity
    {
        T GetById(int Id);
        IList<T> GetAll();
        void Save(T entity);
        void Delete(T entity);
    }
}
