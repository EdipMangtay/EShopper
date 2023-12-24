using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity
{
    public class ProductCategory
    {
        // Many to many relation (Bir kategori altında birden fazla ürün bulunabilir bir ürün birden fazla kategoriyeait olabilir )
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
