using Microsoft.AspNetCore.Mvc;
using TestAPI.Controllers;
using TestAPI.Data;
using TestAPI.Models;

namespace UnitTest
{
    public class MarcasAutosControllerTest
    {
        MarcasAutosController _controller;

        public MarcasAutosControllerTest()
        {
            _controller = new MarcasAutosController(null);
        }

        [Fact]
        public void GetAll_MarcasAutos_Success()
        {
            // Arrange

            // Act
            var result = _controller.GetMarcasAutos();
            var resultType = result as OkObjectResult;
            var resultList = resultType.Value as List<MarcasAutos>;

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<MarcasAutos>>(resultType.Value);
            Assert.Equal(3, resultList.Count);
            
            foreach (MarcasAutos marca in resultList)
            {
                Assert.True(marca.Id > 0, "Id debe ser mayor a 0");
                Assert.True(marca.Marca.Length <= 51 && marca.Marca.Length > 0, "Descripción es requerida y menor a 51 caracteres");
            }
        }
    }
}