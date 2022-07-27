using kkk.Model;
using kkk.Service;
using Microsoft.AspNetCore.Mvc;

namespace Components.ProductBox
{

    [ViewComponent]
    public class ProductBox : ViewComponent
    {
        private readonly CategoryService _categorys;

        public ProductBox(CategoryService categorys)
        {
            _categorys = categorys;
        }

        public IViewComponentResult Invoke(bool sapxep = true)
        {

            List<Category> category = null;
            if (sapxep)
            {
                category = _categorys.categori.OrderBy(x => x.Id).ToList();
            }
            else
            {
                category = _categorys.categori.OrderByDescending(x => x.Id).ToList();

            }
            return View(category);
        }
    }
}
