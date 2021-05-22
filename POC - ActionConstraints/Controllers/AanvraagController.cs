using Microsoft.AspNetCore.Mvc;
using POC___ActionConstraints.Infrastructure;

namespace POC___ActionConstraints.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AanvraagController : Controller
	{
		[HttpPatch, HttpHeader("LV-Command", "Indienen")]
		public IActionResult Indienen()
		{
			return Ok();
		}

		[HttpPatch, HttpHeader("LV-Command", "InBehandelingZetten")]
		public IActionResult InBehandelingZetten()
		{
			return Ok();
		}
	}
}