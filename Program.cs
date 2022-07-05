using System.Globalization;
namespace Exercicio1
{
    public class Exercicio1_udemy
    {
        static void Main()
        {
            string[] v = Console.ReadLine().Split(' ');

            double a = double.Parse(v[0], CultureInfo.InvariantCulture);
            double b = double.Parse(v[1], CultureInfo.InvariantCulture);
            double c = double.Parse(v[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double triangulo = (a * c) / 2.0;
            double circulo = pi * c * c;
            double trapezio = (a + b) / 2.0 * c;
            double quadrado = b * b;
            double retangulo = a * b;

            System.Console.WriteLine(triangulo);

            Console.WriteLine("TRIANGULO : "+ triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO : "+ circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO : "+ trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO : "+ quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO : "+ retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
