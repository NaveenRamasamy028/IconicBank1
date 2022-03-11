using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IconicBank1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountBalanceController : ControllerBase
    {
        public static iconicbankingContext db = new iconicbankingContext();
        [HttpGet]
        public IActionResult GetAccountBalances()
        {
            return Ok();
        }
    }
}
