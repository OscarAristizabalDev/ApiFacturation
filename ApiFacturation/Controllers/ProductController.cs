using DataAccess.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiFacturation.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Permite consultar todos los productos
        /// </summary>
        /// <returns>El estado de la solicitud</returns>
        [HttpGet]
        public async Task<ActionResult<Product>> Get()
        {
            var products = await _productService.GetAllProduct();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        /// <summary>
        /// Permite crear un producto
        /// </summary>
        /// <param name="newProduct">El nuevo producto a crear</param>
        /// <returns>El estado de la solicitud</returns>
        [HttpPost]
        public async Task<ActionResult<Product>> Create(Product newProduct)
        {
            var product = await _productService.CreateProduct(newProduct);
            return Ok();
        }
    }
}
