using System;
namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        // El método GetMarca, retornará el valor correspondiente al atributo marca.
        public string GetMarca()
        {
            return this.marca;
        }
        // También poseerá el atributo codigoDeBarras, el cual se publicará sólo a través de la conversión explícita nombrada más adelante.
        public float GetPrecio()
        {
            return this.precio;
        }
        // El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
        public static string MostrarProducto(Producto p)
        {
            return String.Format("Marca {0} - Precio {1} - Codigo de barra {2}", p.marca, p.precio, p.codigoDeBarra);
        }
        //Posee las siguientes sobrecargas de operadores:
        //explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        // == (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.
        public static bool operator !=(Producto p, string marcaVerificar)
        {        
            bool auxiliar = false;
            if(p.marca != marcaVerificar)
            {
                auxiliar = true;
            }
            return auxiliar;
        }
        public static bool operator ==(Producto p, string marcaVerificar)
        {
            bool auxiliar = false;
            if (p.marca == marcaVerificar)
            {
                auxiliar = true;
            }
            return auxiliar;
        }
        // == (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
        public static bool operator !=(Producto p1, Producto p2)
        {
            bool auxiliar = false;
            if (p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra)
            {
                auxiliar = true;
            }
            return auxiliar;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool auxiliar = false;
            if (p1.marca == p2.marca&&p1.codigoDeBarra==p2.codigoDeBarra)
            {
                auxiliar = true;
            }
            return auxiliar;
        }
    }   
}
