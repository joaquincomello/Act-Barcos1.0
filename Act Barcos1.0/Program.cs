using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== PERSONAS ==");
            Persona persona1 = new Persona("Ana", 30, "mujer");
            Persona persona2 = new Persona("Geronimo", 25, "hombre");

            persona1.Hablar();
            persona2.Hablar();

            Console.WriteLine("\n== BARCOS ==");
           
            Barco barco1 = new Barco(50, 10);
            Barco barco2 = new Barco(30, 15);

            Console.WriteLine($"¿Vale la pena saquear el barco 1? {(barco1.ValeLaPenaSaquear() ? "Sí" : "No")}");
            Console.WriteLine($"¿Vale la pena saquear el barco 2? {(barco2.ValeLaPenaSaquear() ? "Sí" : "No")}");

            Console.WriteLine("\n== BATALLA DE TANQUES ==");
            
            Tanque tanque1 = new Tanque("El semental italiano", "Italia", 1989, 57, new List<string> { "Argentina", "Chile" });
            Tanque tanque2 = new Tanque("El chinardo", "China.", 1944, 30, new List<string> { "Korea", "Japon" });

            tanque1.Batalla(tanque2);

            Console.WriteLine("\n== BLOQUES ==");
            
            Bloque bloque = new Bloque(3, 4, 5);

            Console.WriteLine($"Largo: {bloque.ObtenerLargo()}");
            Console.WriteLine($"Ancho: {bloque.ObtenerAncho()}");
            Console.WriteLine($"Alto: {bloque.ObtenerAlto()}");
            Console.WriteLine($"Volumen: {bloque.ObtenerVolumen()}");
            Console.WriteLine($"Área de Superficie: {bloque.ObtenerAreaSuperficie()}");

            Console.WriteLine("\nFin del programa. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
    

