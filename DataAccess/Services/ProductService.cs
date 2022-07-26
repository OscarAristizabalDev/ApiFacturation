using DataAccess.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Permite consultar todos los productos
        /// </summary>
        /// <returns>Listado de productos</returns>
        public async Task<List<Product>> GetAllProduct()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }


        /// <summary>
        /// Permite crear un producto
        /// </summary>
        /// <param name="product">prodcuto a crear</param>
        /// <returns>La nueva factura creada</returns>
        public async Task<Product> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }
    }
}
