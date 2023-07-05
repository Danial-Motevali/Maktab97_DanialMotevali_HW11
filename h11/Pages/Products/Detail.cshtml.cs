using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Services;

namespace h11.Pages.Products
{
    public class DetailModel : PageModel
    {
        private readonly ProductRepository _productrepository;
        public DetailModel(ProductRepository productrepository)
        {
            _productrepository = productrepository;
        }
        public Product Detail { get; set; }
        public int Id { get; set; }
        public void OnGet(int id)
        {
            Id = id;
            Detail = _productrepository.GetProductById(Id);
        }
    }
}
