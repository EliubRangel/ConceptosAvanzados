using System;

namespace ConceptosAvanzados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            Calculadora cal = new Calculadora();
            try
            {
                decimal x = decimal.Parse(Console.ReadLine());
                decimal division = cal.Dividir(5,x);
                Console.WriteLine(division);
            }
            catch(DivideByZeroException de)
            {
                Console.WriteLine("Error al dividir por cero");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Error de formato no numerico");
            }
            catch(Exception e)
            {
                Console.WriteLine("Hubo un error inesperado");
            }
            finally
            {
                Console.WriteLine("Terminado");
            }

            Console.WriteLine("Adios");
        }
    }
}
