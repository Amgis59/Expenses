using Expenses.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses.DataAccess
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();

        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
