using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;


namespace TestCalculadora
{
    [TestClass] //DECORADOR
    public class TestCalculadoraString
    {
        CalculadoraString calculadora = new CalculadoraString();
        //Parte I
        [TestMethod]
        public void Add_DeberiaRetornar0_CuandoRecibeEmty()
        {
            int esperado=0;
            int actual;
            string numero = string.Empty;
            actual = calculadora.Add(numero);
            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void Add_DebeRetornarNumero_CuandoRecibeNumero()
        {
            int esperado=10;
            int actual;
            string numero = "10";   
            actual=calculadora.Add(numero);
            Assert.AreEqual(esperado, actual);                    
        }
        [DataRow("3,7",10)]
        [DataRow("345,3",348)]
        [DataRow("1,10",11)]
        [TestMethod]
        public void Add_DebeRetornarLaSuma_CuandoRecibeDosNumero(string numero, int esperado)
        {
            //int esperado = 39;
            int actual;
            //string numero = "34,5";
            actual = calculadora.Add(numero);
            Assert.AreEqual(esperado, actual);
        }
        //ParteII
        [TestMethod]
        public void Add_DebeRetornarLaSuma_CuandoRecibeCualquierCantidadDeNumero()
        {
            int esperado = 28;
            int actual;
            string numero = "1,2,3,4,5,6,7";
            actual = calculadora.Add(numero);
            Assert.AreEqual(esperado, actual);
        }
        //ParteIII
        [TestMethod]
        public void Add_DebeRetornarLaSuma_CuandoRecibeCualquierCantidadDeNumeroSeparadosPorSaltoDeLineaYComas()
        {
            int esperado = 6;
            int actual;
            string numero = "1\n2,3";
            actual = calculadora.Add(numero);
            Assert.AreEqual(esperado, actual);
        }
        //ParteVI
        [TestMethod]
        public void Add_DebeRetornarLaSuma_CuandoRecibeCualquierCantidadDeNumeroSeparadosConCualquierDelimitador()
        {
            int esperado = 10;
            int actual;
            string numero = "//.1.2\n3,4";
            actual = calculadora.Add(numero);
            Assert.AreEqual(esperado, actual);
        }
        //ParteV
        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_DebeRetornarNegativoNoPermitido_CuandoRecibeUnNergativo()
        {         
            string numero = "//.-1.2\n3,4";
            int actual = calculadora.Add(numero);
        }
    }
}
