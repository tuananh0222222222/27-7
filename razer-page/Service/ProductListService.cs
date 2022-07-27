using razer_page.Model;

namespace razer_page.Service
{
    public class ProductListService
    {
        public List<Product> product { get; set; } = new List<Product>()
            {

                new Product () {Name = "Iphone" ,Description = "day  la iphone" , Price = 1},
                new Product () {Name = "Samsung" ,Description = "day  la Samsung" , Price = 2},
                new Product () {Name = "Ipad" ,Description = "day  la Ipad" , Price = 3},
             };
    }
}
