using Api.Application.Features.Products.Command.CreateProduct;
using Api.Application.Features.Products.Command.DeleteProduct;
using Api.Application.Features.Products.Command.UpdateProduct;
using Api.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProducts(CreateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProducts(UpdateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteProducts(DeleteProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
