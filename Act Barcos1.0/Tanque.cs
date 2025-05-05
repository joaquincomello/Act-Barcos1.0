using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Barcos1._0
{
    internal class Tanque
    {
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public int Anio { get; set; }
        public int Peso { get; set; }
        public List<string> Aliados { get; set; }

        public Tanque(string nombre, string pais, int anio, int peso, List<string> aliados)
        {
            Nombre = nombre;
            Pais = pais;
            Anio = anio;
            Peso = peso;
            Aliados = aliados;
        }

        public void Batalla(Tanque otro)
        {
            Console.WriteLine("Batalla entre tanques:");
            Console.WriteLine($"Tanque 1: {Nombre} ({Pais}), Año: {Anio}, Peso: {Peso} toneladas");
            Console.WriteLine($"Tanque 2: {otro.Nombre} ({otro.Pais}), Año: {otro.Anio}, Peso: {otro.Peso} toneladas");

            if (this.Anio > otro.Anio && this.Peso >= otro.Peso)
            {
                Console.WriteLine($"¡{Nombre} gana la batalla!");
            }
            else if (this.Anio < otro.Anio && this.Peso <= otro.Peso)
            {
                Console.WriteLine($"¡{otro.Nombre} gana la batalla!");
            }
            else
            {
                Console.WriteLine("¡La batalla termina en empate!");
            }
        }
    }
}
