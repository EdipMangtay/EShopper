using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entity
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        // onetomany relation bir ürünün birdne fzla resmi olbilir 

        public List<Image> Images { get; set; }

        public Product()
        {
            Images = new List<Image>();

        }


    }
}
