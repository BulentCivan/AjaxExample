﻿using AjaxExample.Interfaces;
using AjaxExample.Model;

namespace AjaxExample.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetAllProducts() => _productRepository.GetAll();

        public Product GetProductById(int id) => _productRepository.GetById(id);

        public void AddProduct(Product product) => _productRepository.Add(product);

        public void UpdateProduct(Product product) => _productRepository.Update(product);

        public void DeleteProduct(int id) => _productRepository.Delete(id);

        public async Task<IEnumerable<Product>> SearchProductsAsync(string searchTerm)
        {
            return await _productRepository.SearchProductsAsync(searchTerm);
        }
    }
}
