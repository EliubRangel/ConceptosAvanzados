using System;

namespace ConceptosAvanzados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 100;
            do
            {

                try
                {
                    Console.WriteLine("Bienvenido a conceptos avanzados");
                    Console.WriteLine("Que desea hacer");
                    Console.WriteLine("Opcion 0 salir");
                    Console.WriteLine("Opcion 1 calculadora");
                    Console.WriteLine("Opcion 2 vota o no vota");
                    opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        Calculadora cal = new Calculadora();
                        decimal x = decimal.Parse(Console.ReadLine());
                        decimal division = cal.Dividir(5, x);
                        Console.WriteLine(division);

                    }
                    else if (opcion == 2)
                    {
                        Persona eliub = new Persona();
                        eliub.Nombre = "Eliub";


                        eliub.Nombre = Console.ReadLine();
                        int anioNacimiento = int.Parse(Console.ReadLine());
                        int mesNacimiento = int.Parse(Console.ReadLine());
                        int diaNacimiento = int.Parse(Console.ReadLine());
                        eliub.FechaNacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
                        if (eliub.PuedeVotar())
                        {
                            Console.WriteLine(eliub.Nombre + " puede votar");
                        }
                        else
                        {
                            Console.WriteLine(eliub.Nombre + " no puede votar");
                        }


                    }
                }
                catch (DivideByZeroException de)
                {
                    Console.WriteLine("Error al dividir por cero");
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Error de formato no numerico");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hubo un error inesperado");
                }
                finally
                {
                    Console.WriteLine("Terminado");
                }
            }
            while (opcion != 0);


            Console.WriteLine("Adios");
        }
    }
}
