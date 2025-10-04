using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorldModel;

namespace Comp584Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedController(WeatherContext context) : ControllerBase
    {
        [HttpPost]
        [Route("/countries")]
        public async Task<ActionResult> PostCountries()
        {

            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost]
        [Route("/cities")]
        public async Task<ActionResult> PostCities()
        {

            await context.SaveChangesAsync();

            return Ok();
        }
    }
}
