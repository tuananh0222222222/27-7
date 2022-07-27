using kkk.Model;

namespace kkk.Service
{
    public class CategoryService
    {
        public List<Category> categori { get; set; } = new List<Category>()
        {
            new Category() { Id = 1, Name ="san pham"},
            new Category() { Id = 2, Name ="mat hang"},
            new Category() { Id = 3, Name ="mat hang"},
            new Category() { Id = 4, Name ="mat hang"}
        };
    }
}
