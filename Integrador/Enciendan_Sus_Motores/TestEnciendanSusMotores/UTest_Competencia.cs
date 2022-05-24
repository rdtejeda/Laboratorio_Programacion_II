using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace TestEnciendanSusMotores
{
    [TestClass]
    public class UTest_Competencia
    {
        //AutoF1 a1 = new AutoF1();
        //Competencia c = new Competencia();
        [TestMethod]
        public void ConstructorCompetenciaUno_CuandoCreaNuevoObjeto_DebeInstanciarListaDeVehiculos()
        {
            Competencia c = new Competencia();
            Assert.IsNotNull(c.ListaVehiculosDeCarrera);
        }
        [TestMethod]
        public void ConstructorCompetenciaDos_CuandoCreaNuevoObjeto_DebeInstanciarListaDeVehiculos()
        {
            Competencia c = new Competencia(1,1,Biblioteca.ETipoCompetencia.F1);
            Assert.IsNotNull(c.ListaVehiculosDeCarrera);
        }
    }
}
