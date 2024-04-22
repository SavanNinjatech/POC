using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using POC.Dtos;

namespace POC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogFactsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<dynamic>> GetFacts(int no)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://dog-api.kinduff.com//api/facts");

            var response = await client.GetAsync("?number=" + no);
            if(response != null && response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return Ok(JsonConvert.DeserializeObject<Dogs>(data));
            }
            return BadRequest();
        }
    }
}
