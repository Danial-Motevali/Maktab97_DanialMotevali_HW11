using Models;
using Services.Interface;

namespace Services.Services
{
    public class ProductRepository : IProductRepository
    {
        public readonly List<Product> _products;
        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "green car", Barcode = 24335325, Description = "the very green car", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRthkRnm5qxFIn9M0vscRhs_CPssdq6U60B9w&usqp=CAU", Price = 20 },
                new Product { Id = 2, Name = "red car", Barcode = 24335325, Description = "the very red car", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXcioY95lYQ2L_H3pYmKSOxc4ioPEy-uFu4w&usqp=CAU", Price = 12 },
                new Product { Id = 4, Name = "yellow car", Barcode = 24335325, Description = "the very yellow car", Photo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8mK5e4J7XBrtyatw92HhhSmfoEu1zffmLfg&usqp=CAU", Price = 50 }
            };
        }

        public bool Updata(int id, Product newProduct)
        {
            var product1 = _products.FirstOrDefault<Product>(p => p.Id == id);
            if (product1 != null)
            {
                product1.Name = newProduct.Name;
                product1.Price = newProduct.Price;
                product1.Description = newProduct.Description;
                product1.Photo = newProduct.Photo;

                return true;
            }
            return false;
        }
        public IEnumerable<Product> GetAllProduct()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            foreach(var item in _products)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

    }
    
}

