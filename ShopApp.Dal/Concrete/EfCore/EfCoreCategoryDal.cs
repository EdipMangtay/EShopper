using ShopApp.Dal.Abstract;
using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Concrete.EfCore
{
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category,ShopContext>,ICategoryDal
    {
       
    }
}
