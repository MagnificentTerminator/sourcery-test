using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data.Services;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult Index()
        {
            try
            {
                return Ok(_service.GetProducts());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            try
            {
                return Ok(_service.GetProduct(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                _service.AddProduct(product);
                return Ok(new { Success = "Successfully added new record" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            try
            {
                _service.UpdateProduct(product);
                return Ok(new { Success = "Successfully updated record" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            try
            {
                _service.DeleteProduct(id);
                return Ok(new { Success = "Successfully deleted record" });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}