using Application.Dto;
using Application.Feature.ProductCrud.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    
    public class ProductTypeController : BaseController
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IMediator _mediatR;

        public ProductTypeController(ILogger<ProductController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }
        [HttpPost]
        public ActionResult Add(AddProductTypeDto AddProductType)
        {
            return Ok(_mediatR.Send(new AddProductTypeRequest(AddProductType)).Result);
        }
        [HttpGet]

        public async Task< ActionResult<IReadOnlyList<ProductTypeDto>>> GetAll()
        {
            return  Ok(_mediatR.Send(new GetProductTypeRequest()).Result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<IReadOnlyList<ProductTypeDto>>> GetById(int id)
        {
            return Ok(_mediatR.Send(new GetProductTypeRequest()).Result);
        }
    }
}