using System;
using System.Globalization;

namespace Calculo
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opição: ");
            Console.WriteLine("1 - Calculo de IMC.");
            Console.WriteLine("2 - Calculo de Área.");
            Console.WriteLine("3 - Regra de Três.");
            Console.WriteLine("4 - Sair.");

            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                IMC();

            }
            else if (x == 2)
            {
                Area();
            }
            else if (x == 3)
            {
                Regra();
            }
            else
            {
            }

        }

        public static void IMC()
        {
            IMC p = new IMC();

            Console.WriteLine("Entre com seu peso: ");
            p.Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com sua altura: ");
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




            Console.WriteLine("Valor do IMC: " + p.ValorImc());
          
        }
        public static void Area()
        {
            Area a = new Area();

            Console.WriteLine("Entre com o raio: ");
            a.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Pi = 3.14159265;
            

            Console.WriteLine("Valor do raio: " + a.AreaRaio());
        }

        public static void Regra()
        {
            RegraDeTres r = new RegraDeTres();

            Console.WriteLine("Entre com o primeiro valor:");
            r.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o segundo valor: ");
            r.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o terceiro valor: ");
            r.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            Console.WriteLine("O valor é: " + r.Regra());
        }
    }
}
