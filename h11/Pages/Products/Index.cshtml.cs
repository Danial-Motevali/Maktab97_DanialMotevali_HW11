using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Services;

namespace h11.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductRepository _productrepository;
        public IndexModel(ProductRepository productrepository)
        {
            _productrepository = productrepository;
        }
        public IEnumerable<Product> Products { get; set; }
        public void OnGet(List<Product> products)
        {
            if(products.Count == 0)
            {
                Products = _productrepository.GetAllProduct();
            }
            else
            {
                Products = products;
            }
        }
    }
}
