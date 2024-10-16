using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();
        public T? GetById<TId>(TId id);
        //public T Add(T entiity);
        //public T Update(T entity);
    }
}
