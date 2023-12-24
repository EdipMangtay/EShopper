using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Abstract
{
    public interface IRepository<T> //T ifadesi generic type anlamına gelmektedir
    {
        T GeybyId(int id);
        T GetOne(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
