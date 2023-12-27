namespace SimplePipelineAPI.Tests
{
	using Controllers;

	using Microsoft.AspNetCore.Mvc;

	using NUnit.Framework;

	[TestFixture]
	public class AnimeControllerTests
	{
		[Test]
		public void Get_GetRandomWeatherForecast_ResultIsNotNull()
		{
			var controller = new AnimeController();

			var result = controller.Get();
			var okResult = result as OkObjectResult;

			Assert.IsNotNull(okResult);
		}
	}
}