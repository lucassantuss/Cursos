using Alura.ByteBank.WebApp.Testes.Util;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.ByteBank.WebApp.Testes
{
    public class NavegandoNaPaginaHome:IClassFixture<Fixture>
    {
        private IWebDriver driver;

        //Setup
        public NavegandoNaPaginaHome(Fixture fixture)
        {
            driver = fixture.Driver;
        }
        [Fact]
        public void CarregaPaginaHomeEVerificaTituloDaPagina()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309");
            //Assert
            Assert.Contains("WebApp", driver.Title);

        }

        [Fact]
        public void CarregadaPaginaHomeVerificaExistenciaLinkLoginEHome()
        {
            //Arrange
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)); ;
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309");
            //Assert
            Assert.Contains("Login", driver.PageSource);
            Assert.Contains("Home", driver.PageSource);

        }
    }
}
