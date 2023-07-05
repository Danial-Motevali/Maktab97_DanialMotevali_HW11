using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Services;

namespace h11.Pages.Products
{
    public class DeleteModel : PageModel
    {
        public List<Product> products = new List<Product>();

        private readonly ProductRepository _productrepository;
        public DeleteModel(ProductRepository productrepository)
        {
            _productrepository = productrepository;
        }
        public IEnumerable<Product> Products { get; set; }
        public void Find(int id)
        {
            var allProduct = _productrepository.GetAllProduct();
            foreach (var product in allProduct)
            {
                if (!(product.Id == id))
                products.Add(product);
            }
        }
        public void OnGet(int id)
        {
            Find(id);
            Products = products;
        }
    }
}
