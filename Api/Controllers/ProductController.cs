using Application.Dto;
using Application.Feature.ProductCrud.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    
    public class ProductController : BaseController
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IMediator _mediatR;

        public ProductController(ILogger<ProductController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<ProductDto>>>GetAll(int productTypeId)
        {
            return Ok(_mediatR.Send(new GetProductRequest(productTypeId)).Result);
        }
    }
}