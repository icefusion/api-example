using Microsoft.AspNetCore.Mvc;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Services;
using Ecommerce.Domain.Interfaces;

namespace Ecommerce.Web.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    // private readonly IService<Product> _productsService;

    private readonly ProductsService _productsService;

    private readonly ILogger<ProductsController> _logger;

    // public ProductsController(ILogger<ProductsController> logger, IService<Product> productsService)
    public ProductsController(ILogger<ProductsController> logger, ProductsService productsService)
    {
        _logger = logger;
        _productsService = productsService;
    }

    [HttpGet]
    [Route("list")]
    public List<Product> Get()
    {        
        List<Product> list = _productsService.List();
        
        Array arrayData = list.ToArray();

        return list;
    }
}
