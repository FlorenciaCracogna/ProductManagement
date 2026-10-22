using System;
using System.Collections.Generic;
using System.Text;
using ProductManagement.Models;

namespace ProductManagement.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product? GetById(int id);
        List<Product> GetByCategory(string category);
    }
}
