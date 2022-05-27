using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class EquipoFutbol : Equipo
    {
        public EquipoFutbol(string nombre, DateTime fechaCreacion) : base(nombre, fechaCreacion)
        {
        }

        //public override bool Equals(object obj)
        //{
        //    return (obj is EquipoFutbol futbol && Nombre == futbol.Nombre && FechaCreacion == futbol.FechaCreacion);
        //}
    }
}
