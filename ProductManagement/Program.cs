using ProductManagement.Interfaces;
using ProductManagement.Models;
using ProductManagement.Repositories;

IProductRepository repo = new ProductRepository();

Console.WriteLine("===Lista completa de productos===");
foreach (var p in repo.GetAll())
{
    Console.WriteLine($"ID: {p.Id}, Nombre: {p.Name}, Precio: {p.Price:N2}, Categoría: {p.Category}, Activo: {p.IsActive}");
}

Console.WriteLine();
Console.WriteLine("===Buscar producto por ID: 2===");
var product = repo.GetById(2);
if (product != null)
{
    Console.WriteLine($"ID: {product.Id}, Nombre: {product.Name}, Precio: {product.Price:N2}");
}
else
{
    Console.WriteLine("Producto no encontrado.");
}

Console.WriteLine();
Console.WriteLine("===Buscar productos por categoría: Electrónica===");
var electronicsProducts = repo.GetByCategory("electrónica");
foreach (var p in electronicsProducts)
{
    Console.WriteLine($"ID: {p.Id}, Nombre: {p.Name}, Categoría: {p.Category}, Precio: {p.Price:N2}");
}

Console.WriteLine();
Console.WriteLine("===Agregar un nuevo producto===");
var newProduct = new Product
{
    Id = 5,
    Name = "Cuaderno A4",
    Price = 4500.00m,
    Category = "Librería",
    IsActive = true
};
repo.Add(newProduct);
Console.WriteLine("Producto agregado exitosamente.");
foreach (var p in repo.GetAll())
{
    Console.WriteLine($"ID: {p.Id}, Nombre: {p.Name}, Categoría: {p.Category}, Precio: {p.Price:N2}");
}