using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();
        }

        static void ejer1()
        {
            string nombre, carrera;
            Console.Write("ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido a FA de {carrera}");
            
        } 
        
    }           
}