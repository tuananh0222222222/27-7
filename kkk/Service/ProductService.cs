using kkk.Model;


namespace kkk.Service
{
    public class ProductService
    {
        private List<Product> product = new List<Product>();


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
                Name = "iphone",
                Description = "iphone 12",
                Price = 10000
            });
            product.Add(new Product()
            {
                Id = 2,
                Name = "amsung",
                Description = "iphone 12",
                Price = 10000
            });
            product.Add(new Product()
            {
                Id = 3,
                Name = "nokia",
                Description = "iphone 12",
                Price = 10000
            });
        }

        public Product Find(int Id)
        {
            var qr = from p in product
                        where p.Id == Id
                        select p;

            return qr.FirstOrDefault();

        }

        public List<Product> AllProduct() => product;

    }

}
