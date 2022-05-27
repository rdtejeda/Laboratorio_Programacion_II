using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;

namespace TestStringExtendido
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadasPorEspacio_DeberiaRetornarDos()
        {
            //Arrange
            string texto = "Hola mundo";
            int expected = 2;
            int actual;
            //Act

            actual = texto.ContarPalabras();

            //Assert

            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            //Arrange
            string texto = "Hola-mundo";
            int expected = 2;
            int actual;
            //Act

            actual = texto.ContarPalabras();

            //Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ContarPalabras_CuandoRecibeUnStringEmpty_LanzaArgumentException()
        {
            //Arrange
            string t = string.Empty;
            //Act
            int actual = t.ContarPalabras();

            //Assert
        }
    }
}
