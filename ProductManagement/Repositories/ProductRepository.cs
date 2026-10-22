using System;
using System.Collections.Generic;
using System.Text;
using ProductManagement.Models;
using ProductManagement.Interfaces;

namespace ProductManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "Notebook Lenovo", Price = 850000.00m, Category = "Electrónica", IsActive = true },
                new Product { Id = 2, Name = "Mouse inalámbrico", Price = 15999.99m, Category = "Electrónica", IsActive = true },
                new Product { Id = 3, Name = "Silla de oficina", Price = 120500.50m, Category = "Muebles", IsActive = true },
                new Product { Id = 4, Name = "Escritorio de madera", Price = 230000.00m, Category = "Muebles", IsActive = false }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public List<Product> GetByCategory(string category)
        {
            return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
