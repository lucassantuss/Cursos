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
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309");
            //Assert
            Assert.Contains("WebApp", driver.Title);
        }

        [Fact]
        public void CarregadaPaginaHomeVerificaExistenciaLinkLoginEHome()
        {
            //Arrange
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)); ;
            //Act
            driver.Navigate().GoToUrl("https://localhost:44309");
            //Assert
            Assert.Contains("Login", driver.PageSource);
            Assert.Contains("Home", driver.PageSource);
        }

        [Fact]
        public void ValidaLinkDeLoginNaHome()
        {
            //Arrange
            driver.Navigate().GoToUrl("https://localhost:44309");
            var linkLogin = driver.FindElement(By.LinkText("Login"));
            //Act
            linkLogin.Click();

            //Assert
            Assert.Contains("img", driver.PageSource);

        }

        [Fact]
        public void AcessaPaginaSemEstarLogado()
        {
            //Arrange
            //Act  
            driver.Navigate().GoToUrl("https://localhost:44309/Agencia/Index");           
               

            //Assert
            Assert.Contains("401", driver.PageSource);

        }

        [Fact]
        public void AcessaPaginaSemEstarLogadoVerificaURL()
        {
            //Arrange
            //Act 
            driver.Navigate().GoToUrl("https://localhost:44309/Agencia/Index");

            //Assert
            Assert.Contains("https://localhost:44309/Agencia/Index",driver.Url);
            Assert.Contains("401", driver.PageSource);

        }



    }
}
