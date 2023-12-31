using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services.Services;
using System.Xml.Linq;

namespace h11.Pages.Products
{

    public class EditModel : PageModel
    {
        private readonly ProductRepository _productrepository;
        public EditModel(ProductRepository productrepository)
        {
            _productrepository = productrepository;
        }
        public IEnumerable<Product> Products { get; set;}
        public Product Product { get; set;}
        public Product Product1 { get; set;}
         
        public void OnGet(int id)
        {
            Product = _productrepository.GetProductById(id);
        }
        public IActionResult OnPost(int id, string newName, int newPrice, string newDescription, int newBarcode, string newPhoto)
        {
            Product.Name = newName;
            Product.Price = newPrice;
            Product.Description = newDescription;
            Product.Barcode = newBarcode;
            Product.Photo = newPhoto;

            _productrepository.Updata(id, Product);

            return RedirectToPage("/Products/Index");
        }
    }
}
