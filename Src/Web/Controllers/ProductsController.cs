using Application.Contracts;
using Application.Features.Products.Queries.GetAll;
using Domain.Entites;
using Microsoft.AspNetCore.Mvc;
using Web.Common;

namespace Web.Controllers
{
    public class ProductsController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new GetAllProductsQuery(),cancellationToken));
        }
    }
}
