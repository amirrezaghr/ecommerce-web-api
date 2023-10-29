using Application.Contracts;
using Domain.Entites;
using Microsoft.AspNetCore.Mvc;
using Web.Common;

namespace Web.Controllers
{
    public class ProductsController : BaseApiController
    {
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
    }
}
