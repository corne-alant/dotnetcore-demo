using System;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace tests
{
    public class ApiTests : IClassFixture<WebApplicationFactory<web.Startup>>
    {

        private readonly WebApplicationFactory<web.Startup> _factory;

        public ApiTests(WebApplicationFactory<web.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async void LetsTestOurApi()
        {
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync("https://localhost:5001/api/SampleData/WeatherForecasts?startDateIndex=0");

        // Assert
        response.EnsureSuccessStatusCode(); 

        }
    }
}
