using AjaxExample.Model;
using System.Collections.Generic;

namespace AjaxExample.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
        Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm);
    }
}
