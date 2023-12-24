using ShopApp.Dal.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Concrete.EfCore
{
    public class EfCoreProductDal : IProductDal
    {
        
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product GeybyId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GrtPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
