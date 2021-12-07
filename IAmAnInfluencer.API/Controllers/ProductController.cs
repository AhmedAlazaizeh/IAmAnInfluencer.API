using IAmAnInfluencer.Core.Data;
using IAmAnInfluencer.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        public bool updateProduct(Product product)
        {
            return productService.updateProduct(product);
        }

        [HttpGet]
        [Route("countOfAvailableProducts")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public int countOfAvailableProducts()
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

        [Route("uploadImage")]
        [HttpPost]
        public Product UploadIMage()
        {
            try
            {
                var file = Request.Form.Files[0];//:c:/usersdkosf//c:/users/users/desktop/image.jpeg
                byte[] fileContent;
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    fileContent = ms.ToArray();
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                //decoder for image name , no duplicate errors
                string attachmentFileName = $"{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                //path for angualr project file
                var fullPath = Path.Combine("C:\\Users\\User\\Desktop\\dashboard\\dashboards\\src\\assets\\Image\\", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Product item = new Product();
                item.image = attachmentFileName;
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
