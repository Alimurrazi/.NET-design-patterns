using cqrsMediatr.Commands;
using cqrsMediatr.Models;
using cqrsMediatr.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace cqrsMediatr.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody]Product product)
        {
            await _mediator.Send(new AddProductCommand(product));
            var res = await _mediator.Send(new GetProductByIdQuery(product.Id));
            return Ok(res);
        }
    }
}
