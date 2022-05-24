using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestEnciendanSusMotores
{
    [TestClass]
    public class UTest_AutoF1
    {
        AutoF1 a1 = new AutoF1();
        AutoF1 a2 = new AutoF1();
        [TestMethod]
        public void OperadorIgualIgual_CuandoRecibeDosAutosMismoNumerYExscuderia_DevulveTrue()
        {
            a1.Escuderia = a2.Escuderia = "Ferrari";
            a1.Numero = a2.Numero = 1;
            Assert.IsTrue(a1==a2);
        }
        [TestMethod]
        public void OperadorDistinto_CuandoRecibeDosAutosMismoNumerYExscuderia_DevulveTrue()
        {
            a1.Escuderia = a2.Escuderia = "Ferrari";
            a1.Numero = 2;
            a2.Numero = 1;
            Assert.IsTrue(a1 != a2);
        }
    }
}
