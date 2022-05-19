using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BibliotecaUniversidad;
using System.Collections.Generic;

namespace ProyectoPrueba
{
    [TestClass]
    public class Test_Universidad
    {
        List<Alumno> listaAlumn;
        List<Alumno> listaAlumnAux;
        [TestInitialize]
        public void TestInizialisacion() //CONSTRUCTOR ESTATICO DE INSTANCIA
        {
            listaAlumn = Universidad.Alumnos;
            listaAlumnAux = new List<Alumno>()
            {
                new Alumno(0,1,null,null,90),
                new Alumno(53,456,"Raul","Perez",34),
            };
        }
        [TestMethod]
        public void Test_Login_Correcto()
        #region Login correcto
        {
            ///Emular Datos iniciales necesarios Arrenge
            string pas = "lucas123";
            int id = 123123;
            ///Usar LLamar metodo a ejecutar Act
            bool result = Universidad.Loguear(id, pas);
            ///Evaluar resultado Assert
            Assert.IsTrue(result); ///Assert aqui es clase estatica y sus un metodo de la clase para evaluar
            //Assert.AreSame compara referenecia
            //Assert.Equals si son iguales // IsTrue es como un if && || etc  IsFalse
        }
        #endregion
        #region Datos para prueba Error
        [DataRow(10,"pepe")]/// Tag quye me permitre parametrizar el metodo y llamarlo las veces que quiera
        [DataRow(12,"htgfd")]
        [DataRow(0,"sljkdhfg")]
        [DataRow(-12,"jashdfg")]
        //[DataRow(0,null)] ////NO TIRA Unauthoxxx Por trim de la validacion de la biblioteca de clase
        //[DataRow(123123,"lucas123")]//Good date, not error!
        #endregion
        [ExpectedException(typeof(UnauthorizedAccessException))]///pongo que excepcio espero
        [TestMethod] //digo que es metodo de testeo
        public void Test_Login_Errores(int idPrueba, string passPrueba)//quiero pasar varios valores loparametrizar
        #region Login incorrecto
        {
            ///Emular Datos iniciales necesarios Arrenge PARAMETRIZADO
            ///Usar LLamar metodo a ejecutar Act
            bool result = Universidad.Loguear(idPrueba,passPrueba);
            ///Evaluar resultado Asser //SIN ASSER CON ETIQUETA PORQUE BUSCO EL ERROR
            //string.IsNullOrEmpty
        }
        #endregion
        [TestMethod] //digo que es metodo de testeo
        public void Test_ListaAlumnaLlena_Bien()//quiero pasar varios valores loparametrizar
        {
           // List<Alumno> listaAlumn = Universidad.Alumnos;
            Assert.IsNotNull(listaAlumn);
            Assert.IsTrue(listaAlumn.Count > 0);
            System.Console.WriteLine("Cantidad de alumnos "+ listaAlumn.Count);
        }
        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod] //digo que es metodo de testeo
        public void Test_AlumnaToString_Error()//quiero pasar varios valores loparametrizar
        {
            foreach (Alumno item in listaAlumnAux)
            {
                item.ToString();
            }           
            Assert.IsTrue(true);
        }
    }
}
