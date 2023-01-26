using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Context;

namespace ToDo.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected ToDoDBContext context;
        public  Repository( ToDoDBContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
           context.Set<T>().Add(entity);
        }

      
        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }


       
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public IEnumerable<T> GetAll() => context.Set<T>().ToList();

        public T FirstOrDefault(Func<T,bool> predicate)
        {
            return context.Set<T>().FirstOrDefault(predicate);
        }

       
    }
}
