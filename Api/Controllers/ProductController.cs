using Application.Feature.ProductCrud.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IMediator _mediatR;

        public ProductController(ILogger<ProductController> logger, IMediator mediatR)
        {
            _logger = logger;
            _mediatR = mediatR;
        }

        [HttpGet(Name = "GetAllProduct")]
        public ActionResult GetAll()
        {
            try
            {
                return Ok(_mediatR.Send(new GetProductRequest()));
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally{

            }
        }
    }
}