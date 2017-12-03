using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace jenkin_test_integration
{
	public class ValuesControllerFixture<TStartup> : IDisposable where TStartup : class
	{
		private readonly TestServer _server;
		public HttpClient Client { get; }

		public ValuesControllerFixture()
		{
			var builder = new WebHostBuilder().UseStartup<TStartup>();
			_server = new TestServer(builder);

			Client = _server.CreateClient();
			Client.BaseAddress = new Uri("http://localhost:5000");
		}

		public void Dispose()
		{
			Client.Dispose();
			_server.Dispose();
		}
	}
}
