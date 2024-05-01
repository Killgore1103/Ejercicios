using Clases;
using System.Text;

namespace Calculadora_de_formas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura> ();

            Cuadrado cuadrado = new Cuadrado(12f);
            Circulo circulo = new Circulo(9f);
            Rectangulo rectangulo = new Rectangulo(5f, 7f);

            figuras.Add(cuadrado);
            figuras.Add(circulo);
            figuras.Add(rectangulo);


            StringBuilder sb = new StringBuilder();

            foreach(Figura figura in figuras)
            {
                sb.AppendLine($"Tipo: {figura.GetType().ToString()}");
                sb.AppendLine($"{figura.Dibujar()}");
                sb.AppendLine($"Perimetro: {Math.Round(figura.CalcularPerimetro(), 2).ToString()}");
                sb.AppendLine($"Superficie: {Math.Round(figura.CalcularSuperficie(), 2).ToString()}");
                sb.AppendLine("------------------------------------------------------------");
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
