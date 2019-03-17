using System.Collections.Generic;
using System.Linq;
using Moq;
using SportsStore.Controllers;
using SportsStore.Models;
using SportsStore.Tests.ProductControllerTests;
using Xunit;

namespace SportsStore.Tests
{
    public class ProductControllerTest : TestBase
    {

        [Fact]
        public void CheckFirstPage()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            mock.Setup(m => m.Products).Returns(this.getQueryableMock());

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            IEnumerable<Product> result = controller.List(1).ViewData.Model as IEnumerable<Product>;

            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 3);
            Assert.Equal(mockObject[0].Name, prodArray[0].Name);
            Assert.Equal(mockObject[1].Name, prodArray[1].Name);
            Assert.Equal(mockObject[2].Name, prodArray[2].Name);

        }


        [Fact]
        public void CheckLastPage()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();

            mock.Setup(m => m.Products).Returns(this.getQueryableMock());

            ProductController controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            IEnumerable<Product> result = controller.List(2).ViewData.Model as IEnumerable<Product>;

            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("P4", prodArray[0].Name);
            Assert.Equal("P5", prodArray[1].Name);

        }
    }
}
