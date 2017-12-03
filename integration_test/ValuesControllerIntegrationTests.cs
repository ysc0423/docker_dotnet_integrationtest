using jenkin_test;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace jenkin_test_integration
{
	public class ValuesControllerIntegrationTests : IClassFixture<ValuesControllerFixture<Startup>>
    {
		public HttpClient Client { get; }

		public ValuesControllerIntegrationTests(ValuesControllerFixture<Startup> fixture)
		{
			Client = fixture.Client;
		}

		[Fact]
		public async Task Get_Values()
		{
			// Arrange
			var request = new HttpRequestMessage(new HttpMethod("GET"), "/api/values");

			// Act
			var response = await Client.SendAsync(request);

			// Assert
			Assert.Equal(HttpStatusCode.OK, response.StatusCode);
			var content = await response.Content.ReadAsStringAsync();

			Assert.Equal("[\"value1\",\"value2\"]", content);			
		}
	}
}
