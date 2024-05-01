using Clases;

namespace Central_Telefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Local provincial = new Local("Adrogue", 12.5f, "Lomas de Zamora", 24f);

            Console.WriteLine(provincial.CostoLlamada);


            

        }
    }
}
