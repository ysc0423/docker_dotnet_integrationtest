using jenkin_test.Service;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace jenkin_test.Controllers
{
	[Route("api/[controller]")]
    public class ValuesController : Controller
    {
		private readonly IValueService _valueService;

		public ValuesController(IValueService valueService)
		{
			_valueService = valueService;
		}

        [HttpGet]
        public IActionResult Get()
        {
			var user = _valueService.Get();

			return user.Any() ? (IActionResult)Ok(user) : NotFound();
        }        
    }
}
