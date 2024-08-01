using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b, a, area, perimetro, diagonal;
 
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            area = b * a; // area = base * altura
            perimetro = 2 * b + 2 * a; // ou 2 * ( b + a);   perimetro = 2 * base + 2 * altura  
                                       // Math.Sqrt() = raiz quadrada
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));  // diagonal = raiz base² + altura²
                                                                        // Math.Pow = elevado ao quadrado



            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
