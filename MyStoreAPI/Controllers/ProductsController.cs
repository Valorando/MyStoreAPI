﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyStoreAPI.Interfaces;

namespace MyStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }
    }
}
