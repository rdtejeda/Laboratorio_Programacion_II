using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibiloteca;

namespace TestIntExtendido
{
    [TestClass]
    public class IntExtendidoTest
    {
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisibleSoloPorTres_DeberiaRetornarFizz()
        {
            //ARRENGE
            string expected = "Fizz";
            string actual;
            int entero = 3;
            //ACT
            actual = entero.FizzBuzz();            
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisibleSoloPorCinco_DeberiaRetornarBuzz()
        {
            //ARRENGE
            string expected = "Buzz";
            string actual;
            int entero = 5;
            //ACT
            actual = entero.FizzBuzz();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [DataRow(15, "FizzBuzz")]
        [DataRow(30, "FizzBuzz")]
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisibleSoloPorTresyCinco_DeberiaRetornarFizzBuzz
            (int entero, string expected)
        {
            //ARRENGE
            string actual;
            //ACT
            actual = entero.FizzBuzz();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [DataRow(4)]//,"4")]
        [DataRow(8)]//,"8")]
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroNoEsDivisiblePorTresoCinco_DeberiaRetornarNumero
            (int entero)//, string expected)
        {
            //ARRENGE
            //string expected = 2.ToString();
            //int entero = 2;
            string expected=entero.ToString() ;
            string actual = entero.FizzBuzz();
            Assert.AreEqual(expected, actual);
        }
        [DataRow(7)]//,"4")]
        [DataRow(10)]//,"8")]
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroNoEsDivisiblePorSiete_DeberiaRetornarNumero
            (int entero)//, string expected)
        {
            //ARRENGE
            //string expected = 2.ToString();
            //int entero = 2;
            string expected = entero.ToString();
            string actual = entero.FizzBuzz();
            Assert.AreEqual(expected, actual);
        }
    }
}
