using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Dal.Abstract
{
    public interface IProductDal:IRepository<Product>
    {
        // interface kendisi public olmak zorundadur çünkü bir arayüzdür ve oluşturulma amacı herkesin bu arayüzü kullanmasıdır 

        //İnterface method bir gövde olmaz her interfaceyi implement eden class kendisi o methodun ne iş yapacağını belirler 
        //CQRS mimari ? okuyucu ve manipülasyon yapan methodları başka şeylere koy diyor
        // MediatR
        // SignalR Anlık mesajlaşma sağlamak için var 


        IEnumerable<Product> GrtPopularProducts();

    }
}
