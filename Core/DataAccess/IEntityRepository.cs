using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic repository oluşturduk..
    //Generic constraint - kısıt vericez T tipine.
    //class olabilir demek değil bu referans tip olabilir demek ve T sadece IEntitye ait olabilir..
    //new() : newlenebilir olmalı.
    public interface IEntityRepository<T> where T:class,IEntity ,new() 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
