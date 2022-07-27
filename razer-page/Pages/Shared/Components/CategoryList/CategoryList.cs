using Microsoft.AspNetCore.Mvc;
using razer_page.Model;
using razer_page.Service;

namespace Components.CategoryList
{
    public class CategoryList : ViewComponent
    {
        CategoryListService category;

        public CategoryList(CategoryListService _category)
        {
            category = _category;
        }

        public IViewComponentResult Invoke()
        {
            List<Category> cate = null;

            cate = category.category.ToList();
            
            return View(cate);
        }
       
    }
}
