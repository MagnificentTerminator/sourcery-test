using System.Collections.Generic;
using System.Linq;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Services
{
    public class ProductService : IProductService
    {

        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product Product = _context.Products.SingleOrDefault(t => t.Id == id);
            if (Product != null)
            {
                _context.Products.Remove(Product);
                _context.SaveChanges();
            }
        }

        public Product GetProduct(int id)
        {
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.OrderBy(c => c.Name).ToList();
        }

        public void UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}