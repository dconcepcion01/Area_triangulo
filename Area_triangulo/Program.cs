using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa calcula el area de un triangulo");
            double bas, altura,area;

            Console.WriteLine("Digite la base del triangulo");
            bas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite la altura del triangulo");
            altura = Convert.ToDouble(Console.ReadLine());

           area= (bas*altura)/ 2;

            Console.WriteLine("El area del triangulo es  :" + area);
            Console.ReadKey();



        }
    }
}
