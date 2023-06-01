using Application.Services;
using CatalogService.Controllers;
using Domain.Dtos;
using FakeItEasy;
using FluentAssertions;

namespace CatalogService.Tests.Controller
{
    public class CatalogControllerTests
    {


        private readonly ICatalogService _catalogService;


        public CatalogControllerTests()
        {
            _catalogService = A.Fake<ICatalogService>();
        }


        [Fact]
        public void CatalogController_GetCatalog_Return_Fake_Data()
        {

            var catalogId = Guid.NewGuid();
            var catalogData = A.Fake<VideoIdDto>();
            A.CallTo(() => _catalogService.GetCatalogByIdAsync(catalogId)).Returns(catalogData);
            A.CallTo(() => _catalogService.GetCalatogAsync());
            var controller = new CatalogController(_catalogService);

            var catalogIdResult = controller.GetCatalogId(catalogId);
            var catalogResult = controller.GetCatalog();
            

            catalogIdResult.Should().NotBeNull();
            catalogResult.Should().NotBeNull();


        }
    }
}