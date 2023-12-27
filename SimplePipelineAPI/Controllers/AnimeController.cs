using Microsoft.AspNetCore.Mvc;

namespace SimplePipelineAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AnimeController : ControllerBase
	{
		private static readonly string[] Anime = new[]
		{
			"Naruto", "One Piece", "Dororo", "Death Note", "Attack on Titan"
		};

		[HttpGet]
		public IActionResult Get()
		{
			var randomIndex = new Random().Next(0, Anime.Length);

			return Ok(new { AnimeName = Anime[randomIndex] });
		}
	}
}
