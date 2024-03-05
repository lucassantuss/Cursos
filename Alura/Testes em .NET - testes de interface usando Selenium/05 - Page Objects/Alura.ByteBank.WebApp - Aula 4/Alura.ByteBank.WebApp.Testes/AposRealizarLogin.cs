using Alura.ByteBank.WebApp.Testes.Util;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.ByteBank.WebApp.Testes
{
    public class AposRealizarLogin : IClassFixture<Fixture>
    {
        private IWebDriver driver;
        public AposRealizarLogin(Fixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void AposRealizarLoginVerificaSeExisteOpcaoAgenciaMenu()
        {
            //Arrange          
            driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            var login = driver.FindElement(By.Id("Email"));//Selecionar elementos do HTML
            var senha = driver.FindElement(By.Id("Senha"));//Selecionar elementos do HTML
            var btnLogar = driver.FindElement(By.Id("btn-logar"));//Selecionar elementos do HTML
          
            login.SendKeys("andre@email.com");
            senha.SendKeys("senha01");

            //act - Faz o login
            btnLogar.Click();

            //Assert
            Assert.Contains("Agência", driver.PageSource);

        }

        [Fact]
        public void TentaRealizarLoginSemPreencherCampos()
        {
            //Arrange          
            driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            var login = driver.FindElement(By.Id("Email"));//Selecionar elementos do HTML
            var senha = driver.FindElement(By.Id("Senha"));//Selecionar elementos do HTML
            var btnLogar = driver.FindElement(By.Id("btn-logar"));//Selecionar elementos do HTML
            
            //login.SendKeys("andre@email.com");
            //senha.SendKeys("senha01");

            //act - Faz o login
            btnLogar.Click();

            //Assert
            Assert.Contains("The Email field is required.", driver.PageSource);
            Assert.Contains("The Senha field is required.", driver.PageSource);

        }

        [Fact]
        public void TentaRealizarLoginComSenhaInvalida()
        {
            //Arrange          
            driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            var login = driver.FindElement(By.Id("Email"));//Selecionar elementos do HTML
            var senha = driver.FindElement(By.Id("Senha"));//Selecionar elementos do HTML
            var btnLogar = driver.FindElement(By.Id("btn-logar"));//Selecionar elementos do HTML

            login.SendKeys("andre@email.com");
            senha.SendKeys("senha010");//senha inválida.

            //act - Faz o login
            btnLogar.Click();

            //Assert
            Assert.Contains("Login", driver.PageSource);
            
        }

        [Fact]
        public void AposRealizarLoginAcessaMenuAgencia()
        {
            //Arrange          
            driver.Navigate().GoToUrl("https://localhost:44309/UsuarioApps/Login");
            var login = driver.FindElement(By.Id("Email"));//Selecionar elementos do HTML
            var senha = driver.FindElement(By.Id("Senha"));//Selecionar elementos do HTML
            var btnLogar = driver.FindElement(By.Id("btn-logar"));//Selecionar elementos do HTML

            login.SendKeys("andre@email.com");
            senha.SendKeys("senha01");
            btnLogar.Click();

            var linkMenu = driver.FindElement(By.Id("agencia"));

            //act - Clicar no Menu
            linkMenu.Click();

            //Assert
            Assert.Contains("Adicionar Agência", driver.PageSource);

        }

    }
}
