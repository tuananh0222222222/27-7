using razer_page.Model;

namespace razer_page.Service
{
    public class CategoryListService
    {

        public List<Category>   category { get; set; } = new List<Category>()
        {
            new Category() {Id = 1, CategoryName = "Tủ lạnh"},
            new Category() {Id = 1, CategoryName = "Máy giặt"},
            new Category() {Id = 1, CategoryName = "TI vi"}
        };
    }
}
