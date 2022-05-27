using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoDeCarrera v1 = new AutoF1(1, "escu1",2000);
            VehiculoDeCarrera v2 = new AutoF1(4, "escu2",2500);
            VehiculoDeCarrera v3 = new AutoF1(5, "escu3",3000);
            VehiculoDeCarrera v4 = new AutoF1(1, "escu1",2900);
            VehiculoDeCarrera v5 = new AutoF1(2, "escu4",2100);
            VehiculoDeCarrera v6 = new MotoCross(12, "escqu1", 200);
            VehiculoDeCarrera v7 = new MotoCross(24, "ewscu2", 500);
            VehiculoDeCarrera v8 = new MotoCross(53, "eswcu3", 300);
            VehiculoDeCarrera v9 = new MotoCross(16, "eschu1", 900);
            VehiculoDeCarrera v10 = new MotoCross(12, "escu14", 210);
            Competencia competenciaF1 = new Competencia(5, 10, Biblioteca.ETipoCompetencia.F1);
            Competencia competenciaMC = new Competencia(5, 10, Biblioteca.ETipoCompetencia.MotoCross);
            if (competenciaMC is not null && competenciaF1 is not null)
            {
                try
                {
                    if (v1 is not null && (competenciaMC + v1))
                    {
                        Console.WriteLine("Se ha agregado al vehiculo numer {0} del la escuderia {1}", v1.Numero, v1.Escuderia);
                        Console.WriteLine("Lista actual de competidores: \n" + competenciaMC.MostrarDatos());
                    }
                }
                catch (CompetenciaNoDisponibleException miExc)
                {
                    Console.WriteLine(miExc.ToString());
                    //Console.WriteLine("Primer excepcion capturada : " + miExc.InnerException.Message);
                   // Console.WriteLine("Segunda excepcion capturada : " + miExc.Message);
                    Console.WriteLine("NO SE HA AGREGO\n" + v1.MostrarDatos());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo la excepcion: "+ex.Message);
                }
                finally
                {
                }
                try
                {
                    if (v10 is not null && (competenciaMC + v10))
                    {
                        Console.WriteLine("Se ha agregado al vehiculo numer {0} del la escuderia {1}", v10.Numero, v10.Escuderia);
                        Console.WriteLine("Lista actual de competidores: \n" + competenciaMC.MostrarDatos());
                    }
                }
                catch (CompetenciaNoDisponibleException miExc)
                {
                    Console.WriteLine(miExc.ToString());
                    Console.WriteLine("NO SE HA AGREGO\n" + v10.MostrarDatos());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo la excepcion: " + ex.Message);
                }
                finally
                {
                }
                //if (competenciaMC + v10)
                //{
                //    Console.WriteLine(competenciaMC.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                try
                {
                    if (v9 is not null && (competenciaMC + v9))
                    {
                        Console.WriteLine("Se ha agregado al vehiculo numer {0} del la escuderia {1}", v9.Numero, v9.Escuderia);
                        Console.WriteLine("Lista actual de competidores: \n" + competenciaMC.MostrarDatos());
                    }
                }
                catch (CompetenciaNoDisponibleException miExc)
                {
                    Console.WriteLine(miExc.ToString());
                    Console.WriteLine("NO SE HA AGREGO\n" + v9.MostrarDatos());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo la excepcion: " + ex.Message);
                }
                finally
                {
                }
                //if (competenciaMC + v9)
                //{
                //    Console.WriteLine(competenciaMC.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                try
                {
                    if (v4 is not null && (competenciaMC + v4))
                    {
                        Console.WriteLine("Se ha agregado al vehiculo numer {0} del la escuderia {1}", v4.Numero, v4.Escuderia);
                        Console.WriteLine("Lista actual de competidores: \n" + competenciaMC.MostrarDatos());
                    }
                }
                catch (CompetenciaNoDisponibleException miExc)
                {
                    Console.WriteLine(miExc.ToString());
                    Console.WriteLine("NO SE HA AGREGO\n" + v4.MostrarDatos());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo la excepcion: " + ex.Message);
                }
                finally
                {
                }
                //if (competenciaMC + v4)
                //{
                //    Console.WriteLine(competenciaMC.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                try
                {
                    if (v5 is not null && (competenciaMC + v5))
                    {
                        Console.WriteLine("Se ha agregado al vehiculo numer {0} del la escuderia {1}", v5.Numero, v5.Escuderia);
                        Console.WriteLine("Lista actual de competidores: \n" + competenciaMC.MostrarDatos());
                    }
                }
                catch (CompetenciaNoDisponibleException miExc)
                {
                    Console.WriteLine(miExc.ToString());
                    Console.WriteLine("NO SE HA AGREGO\n" + v5.MostrarDatos());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo la excepcion: " + ex.Message);
                }
                finally
                {
                }
                //if (competenciaMC + v5)
                //{
                //    Console.WriteLine(competenciaMC.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}

                //if (competenciaMC - v1)
                //{
                //    Console.WriteLine(competenciaMC.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE PUDO ELIMINAR");
                //}
                //if (competenciaMC - v10)
                //{
                //    Console.WriteLine(competenciaMC.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE PUDO ELIMINAR");
                //}
                try
                {
                    if (v1 is not null && (competenciaF1 + v1))
                    {
                        Console.WriteLine("Se ha agregado al vehiculo numer {0} del la escuderia {1}", v1.Numero, v1.Escuderia);
                        Console.WriteLine("Lista actual de competidores: \n" + competenciaMC.MostrarDatos());
                    }
                }
                catch (CompetenciaNoDisponibleException miExc)
                {
                    Console.WriteLine(miExc.ToString());
                    Console.WriteLine("NO SE HA AGREGO\n" + v1.MostrarDatos());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Se produjo la excepcion: " + ex.Message);
                }
                finally
                {
                }
                //if (competenciaF1 + v1)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                //if (competenciaF1 + v10)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                //if (competenciaF1 + v3)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                //if (competenciaF1 + v4)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                //if (competenciaF1 + v5)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE AGREGO");
                //}
                //if (competenciaF1 - v1)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE PUDO ELIMINAR");
                //}
                //if (competenciaF1 - v1)
                //{
                //    Console.WriteLine(competenciaF1.MostrarDatos());
                //}
                //else
                //{
                //    Console.WriteLine("NO SE PUDO ELIMINAR");
                //}
            }
            else
            {
                Console.WriteLine("ALguna competencia no fue instanciada");
            }
        }
    }
}
