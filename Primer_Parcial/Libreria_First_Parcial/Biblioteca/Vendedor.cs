using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        public Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) :this()
        {
            this.nombre = nombre;
        }
        public static bool operator +(Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.HayStock)
            {
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }
        public static string ObtenerInformeVentas(Vendedor vendedor)
        {
            float ganancias = 0;
            StringBuilder sb =  new StringBuilder();
            sb.AppendLine(vendedor.nombre.ToUpper());
            sb.AppendLine("--------------------------");
            foreach (Publicacion item in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACION : {item.ObtenerInformacio()}");
                ganancias += item.Importe;
            }
            sb.AppendLine($"Ganancia Total: ${ganancias}");
           

            return sb.ToString();
        }
    }
}
