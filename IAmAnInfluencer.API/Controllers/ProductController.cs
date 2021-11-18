using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAmAnInfluencer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpPost]
        [Route("Add")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool addProduct(Product product)
        {
            return productService.addProduct(product);
        }

        [HttpDelete]
        [Route("Delete/{ID}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool deleteProduct(int ID)
        {
            return productService.deleteProduct(ID);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> getAllProduct()
        {
            return productService.getAllProduct();
        }

        [HttpPut]
        [Route("Update")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool updateProduct(Product product)
        {
            return productService.updateProduct(product);
        }
    }
}
