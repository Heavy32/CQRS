using Business.UseCases.Beer.CreateBeer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CQRS.Beer
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateBeer(CreateBeerCommand command, [FromServices] CreateBeerHandler handler)
        {

        }
    }
}
