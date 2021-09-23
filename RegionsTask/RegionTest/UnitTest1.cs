using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegionsTask;
using System.Threading.Tasks;
using Xunit;

namespace RegionTest
{
    public class BasicTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public BasicTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }


        [Theory]
        [InlineData("001853483")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string phoneNumber)
        {
            var t = phoneNumber;
            // Arrange
            var _regionclient = _factory.CreateClient();
            //Act
            var response = await _regionclient.GetAsync("/Region/" + phoneNumber);
            // Assert
            response.EnsureSuccessStatusCode(); 
            Assert.Equals(null, response.Content);

        }
    }
}
