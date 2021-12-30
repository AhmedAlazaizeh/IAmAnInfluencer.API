using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.DTO;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
        public bool addProduct(AddProductDTO addProductDTO)
        {
            return productService.addProduct(addProductDTO);
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
        [Route("GetAll")]
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
        public bool updateProduct(AddProductDTO addProductDTO)
        {
            return productService.updateProduct(addProductDTO);
        }

        [HttpGet]
        [Route("countOfAvailableProducts")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfAvailableProducts()
        {
            return productService.countOfAvailableProducts();
        }

        [HttpGet]
        [Route("latestProducts")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> latestProducts()
        {
            return productService.latestProducts();
        }

        [HttpGet]
        [Route("ProductPriceHighToLow")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> ProductPriceHighToLow()
        {
            return productService.ProductPriceHighToLow();
        }

        [HttpGet]
        [Route("ProductPriceLowToHigh")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> ProductPriceLowToHigh()
        {
            return productService.ProductPriceLowToHigh();
        }

        [HttpGet]
        [Route("getProduct/{ID}")]
        [ProducesResponseType(typeof(List<getAProductDTOResult>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<getAProductDTOResult> getProduct(int ID)
        {
            return productService.getProduct(ID);
        }

        [Route("Upload")]
        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Upload()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }

        [HttpGet]
        [Route("getMyProducts/{ID}")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> getMyProducts(int ID)
        {
            return productService.getMyProducts(ID);
        }

        [HttpGet]
        [Route("latestProductsAll")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> latestProductsAll()
        {
            return productService.latestProductsAll();
        }

        [HttpGet]
        [Route("SearchProduct/{searchedFor}")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Product> searchProduct(string searchedFor)
        {
            return productService.searchProduct(searchedFor);
        }

        [HttpGet]
        [Route("countOfInfluncerProducts/{ID}")]
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public object countOfIinfluncerProducts(int ID)
        {
            return productService.countOfIinfluncerProducts(ID);
        }
    }
}
