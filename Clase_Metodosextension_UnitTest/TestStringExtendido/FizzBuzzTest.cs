using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestStringExtendido
{
    [TestClass]
    public  class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePor3_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 6;
            string expected = "Fizz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePor5_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 5;
            string expected = "Buzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePor3Y5_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(4)]
        [DataRow(14)]
        [DataRow(11)]
        public void FizzBuzz_CuandoElNumeroNoEsDivisiblePor3ni5_DeberiaRetornarElMismoNumero(int numero)
        {
            //Arrange
          
            string expected = numero.ToString();

            //Act
            string actual = numero.FizzBuzz();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
