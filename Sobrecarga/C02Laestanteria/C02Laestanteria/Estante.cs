using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Biblioteca
{
    public class Estante
    {
        // Posee dos atributos privados. Uno será un entero que indicará la ubicación del estante y el otro es un array de tipo Producto.
        private Producto[] productos;
        private int ubicacionEstante;
        // El constructor de instancia privado será el único que incializará el array.
        private Estante(int capacida)
        {
            productos = new Producto[capacida];
        }
        // La sobrecarga pública del constructor inicializará la ubicación del estante, recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        //El método público GetProductos, retornará el array de productos.
        public Producto[] GetProcuctos()
        {
            //Producto[] productos;
            //return productos;
            return this.productos;
        }
        //El método público de clase (estático) MostrarEstante,
        //retornará una cadena con toda la información del estante incluyendo el detalle de cada uno de sus productos. Reutilizar código.
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < e.productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                sb.AppendLine("--------------------");
            }
            return sb.ToString();
        }
        //Posee las siguientes sobrecargas de operadores:
        //==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
        public static bool operator ==(Estante e, Producto p)
        {
            bool auxiliar=false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i]==p)
                {
                    auxiliar = true;
                }
            }            
            return auxiliar;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            bool auxiliar = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] != p)
                {
                    auxiliar = true;
                }
            }
            return auxiliar;
        }
        // +: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más
        // y dicho producto no se encuentra en el estante, false caso contrario. Reutilizar código.
        public static bool operator +(Estante e, Producto p)
        {
            bool auxiliar = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null)
                {
                    e.productos[i]=p;
                    auxiliar = true;
                }
            }
            return auxiliar;
        }
        //-: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.
        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e == p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
