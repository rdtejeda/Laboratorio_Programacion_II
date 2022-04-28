using System;
using Biblioteca;


namespace CVehiculoTerrestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre autoUno = new Automovil(6,5,4,5,EColores.Rojo);
            VehiculoTerrestre camionUno = new Camion(7,10000,12,2, EColores.Azul);
            VehiculoTerrestre motoUno = new Moto(750,2,1,EColores.Negro);

            Console.WriteLine($"Auto \n Ruedas: {autoUno.CatidadRuedas}, Puertas : {autoUno.CantidadPuertas}" +
                $", Color : { autoUno.Color}, Marchas : {((Automovil)autoUno).CantidadMarchas}, Pasajeros : {((Automovil)autoUno).CantidadPasajeros}");

            Console.WriteLine($"Camion \n Ruedas: {camionUno.CatidadRuedas}, Puertas : {camionUno.CantidadPuertas}" +
                $", Color : { camionUno.Color}, Marchas : {((Camion)camionUno).CantidadMarchas}, Carga : {((Camion)camionUno).PesoCarga}");

            Console.WriteLine($"Moto \n Ruedas: {motoUno.CatidadRuedas}, Puertas : {motoUno.CantidadPuertas}" +
                $", Color : { motoUno.Color}, Cilindrada : {((Moto)motoUno).Cilindrada}");
        }
    }
}
