using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Xml.Schema;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, aTriandulo, aCirculo, aTrapésio, aQuadrado, aRetangulo;

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            aTriandulo = A * C / 2.0;
            aCirculo = Math.Pow(C,2) * 3.14159;
            aTrapésio = (A + B) / 2.0 * C;
            aQuadrado = B * B;
            aRetangulo = A * B;

            Console.WriteLine("Triangulo: " + aTriandulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + aCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapésio: " + aTrapésio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + aQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + aRetangulo.ToString("F3", CultureInfo.InvariantCulture));


            
        }      
    }
}
