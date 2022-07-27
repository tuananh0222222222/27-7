
using System.Linq;
using _72core.Models;

namespace _72core.Services
{
    public class ProductService
    {
        public List<Product> product = new List<Product>();

        public ProductService()
        {
            LoadProduct();
        }

        public void LoadProduct()
        {
            product.Clear();

            product.Add(new Product()
            {
                Id = 1,
                Name ="iphone",
                Des = "day la sp iphone",
                Price = 1000
                
            });

            product.Add(new Product()
            {
                Id = 2,
                Name = "samsung",
                Des = "day la sp samsung",
                Price = 2000

            });

            product.Add(new Product()
            {
                Id = 3,
                Name = "nokia",
                Des = "day la sp nokia",
                Price = 3000

            });
        }

        public List<Product> AlLProduct() => product;

        public Product Find(int id)
        {
            var qr = from p in product where p.Id == id select p;
            return qr.FirstOrDefault();
        }

    }

    
}
