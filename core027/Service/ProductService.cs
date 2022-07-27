

using core027.Model;

namespace core027.Service
{
    public class ProductService 
    {
        private List<Product> product = new List<Product>();

        public ProductService()
        {
            Load();
        }

        public Product Find(int id)
        {
            var qr = from q in product
                     where q.Id == id
                     select q;
            return qr.FirstOrDefault();
        }
        public void Load()
        {
            product.Clear();

            product.Add(new Product()
            {
                Id = 1,
                Name = "iphone",
                Description = "day la iphone",
                Price = 3
            });
            product.Add(new Product()
            {
                Id = 2,
                Name = "nokia",
                Description = "day la nokia",
                Price = 3
            });
            product.Add(new Product()
            {
                Id = 3,
                Name = "samsung",
                Description = "day la samsung",
                Price = 3
            });
        }
    }
}
