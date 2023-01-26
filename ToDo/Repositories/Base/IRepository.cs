using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Repositories.Base
{
    public interface IRepository<T>
    {
        void Delete (T entity);

        void Add(T entity);
        IEnumerable<T> GetAll();
        void SaveChanges();

        T FirstOrDefault(Func<T, bool> predicate);

    }
}
